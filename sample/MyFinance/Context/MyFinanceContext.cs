namespace MyFinance.Context;

public class MyFinanceContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<OperationItem> OperationItems { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connDb = $"Filename={PathDB.GetPath("MyFinanceDemo.db")}";
            optionsBuilder.UseSqlite(connDb);
        }
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var datas = ChangeTracker.Entries<BaseModel>();
        foreach (var data in datas)
        {
            _ = data.State switch
            {
                EntityState.Added => data.Entity.CreateDate = DateTime.Now,
                EntityState.Modified => data.Entity.UpdateDate = DateTime.Now,
                _ => data.Entity.UpdateDate = DateTime.Now
            };
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}
