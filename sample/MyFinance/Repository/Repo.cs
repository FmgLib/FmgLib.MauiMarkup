using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using System.Linq.Expressions;

namespace MyFinance.Repository;

public class Repo<TModel> : IRepo<TModel> where TModel : BaseModel
{
    private readonly MyFinanceContext _context;

    public Repo(MyFinanceContext context)
    {
        _context = context;
    }

    public DbSet<TModel> Table => _context.Set<TModel>();

    public async Task<List<TModel>> GetAllAsync(Expression<Func<TModel, bool>> expression = null, Expression<Func<TModel, object>> include = null, Expression<Func<TModel, object>> ordered = null, int? skip = null, int? limit = null, bool descOrder = false)
    {
        var query = Table.AsNoTracking();

        if (expression != null)
            query = query.Where(expression);

        if (include != null)
            query = query.Include(include);

        if (ordered != null)
            query = descOrder ? query.OrderByDescending(ordered) : query.OrderBy(ordered);

        if (skip.HasValue)
            query = query.Skip(skip.Value);

        if (limit.HasValue)
            query = query.Take(limit.Value);

        return await query.ToListAsync();
    }

    public async Task<double> GetSumAsync(Expression<Func<TModel, double>> sumProp, Expression<Func<TModel, bool>> expression = null, Expression<Func<TModel, object>> include = null, int? skip = null, int? limit = null)
    {
        var query = Table.AsNoTracking();

        if (expression != null)
            query = query.Where(expression);

        if (include != null)
            query = query.Include(include);

        if (skip.HasValue)
            query = query.Skip(skip.Value);

        if (limit.HasValue)
            query = query.Take(limit.Value);

        return await query.SumAsync(sumProp);
    }

    public async Task<int> GetCountAsync(Expression<Func<TModel, bool>> filter = null)
    {
        var query = Table.AsNoTracking();

        if (filter != null)
            query = query.Where(filter);

        return await query.CountAsync();
    }

    public async Task<TModel?> GetSingleAsync(Expression<Func<TModel, bool>> expression, Expression<Func<TModel, object>> include = null)
    {
        var query = Table.AsNoTracking().Where(expression);

        if (include != null)
            query = query.Include(include);

        return await query.FirstOrDefaultAsync();
    }

    public async Task<bool> InsertAsync(TModel item)
    {
        try
        {
            EntityEntry<TModel> entityEntry = await Table.AddAsync(item);
            await SaveAsync();

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> RemoveAsync(Guid id)
    {
        try
        {
            var model = await Table.FirstOrDefaultAsync(x => x.Id == id);
            var result = Table.Remove(model);
            await SaveAsync();

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public async Task<bool> RemoveRangeAsync(List<Guid> ids)
    {
        try
        {
            var models = await Table.AsNoTracking().Where(x => ids.Contains(x.Id)).ToListAsync();
            Table.RemoveRange(models);
            await SaveAsync();

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

    public async Task<bool> UpdateAsync(TModel item)
    {
        try
        {
            EntityEntry<TModel> entityEntry = Table.Update(item);
            await SaveAsync();

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
