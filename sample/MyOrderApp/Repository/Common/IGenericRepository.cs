using LiteDB;
using System.Linq.Expressions;

namespace MyOrderApp.Repository;

public interface IGenericRepository<TModel> where TModel : BaseModel
{
    // QUERY
    List<TModel> GetAll();
    List<TModel> GetAll(Expression<Func<TModel, bool>> expression);

    TModel Get(Guid id);
    TModel Get(Expression<Func<TModel, bool>> expression);

    int Count();
    int Count(Expression<Func<TModel, bool>> expression);

    // COMMAND
    bool Add(TModel model);
    bool Update(TModel model);
    bool Delete(Guid id);
    bool Delete(Expression<Func<TModel, bool>> expression);

    string UploadFile(string fileName, byte[] data);
    byte[] DownloadFile(string fileId);

    ILiteCollection<TModel> Table { get; }
    ILiteStorage<string> Storage { get; }

    void Save();
}
