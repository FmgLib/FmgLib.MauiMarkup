using System.Linq.Expressions;

namespace MyFinance.Repository;

public interface IRepo<TModel> where TModel : BaseModel
{
    DbSet<TModel> Table { get; }
    Task<int> SaveAsync();

    Task<List<TModel>> GetAllAsync(Expression<Func<TModel, bool>> expression = null, Expression<Func<TModel, object>> include = null, Expression<Func<TModel, object>> ordered = null, int? skip = null, int? limit = null, bool descOrder = false);
    Task<double> GetSumAsync(Expression<Func<TModel, double>> sumProp, Expression<Func<TModel, bool>> expression = null, Expression<Func<TModel, object>> include = null, int? skip = null, int? limit = null);
    Task<TModel?> GetSingleAsync(Expression<Func<TModel, bool>> expression, Expression<Func<TModel, object>> include = null);
    Task<int> GetCountAsync(Expression<Func<TModel, bool>> filter = null);

    Task<bool> InsertAsync(TModel item);
    Task<bool> UpdateAsync(TModel item);
    Task<bool> RemoveAsync(Guid id);
    Task<bool> RemoveRangeAsync(List<Guid> ids);
}
