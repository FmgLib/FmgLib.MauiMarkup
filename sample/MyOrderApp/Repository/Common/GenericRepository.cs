using LiteDB;
using MyOrderApp.Context;
using System.Linq.Expressions;

namespace MyOrderApp.Repository;

public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : BaseModel
{
    MyContext _context = new MyContext();

    public ILiteCollection<TModel> Table => _context.GetLiteDB().GetCollection<TModel>();

    public ILiteStorage<string> Storage => _context.GetLiteDB().GetStorage<string>();

    public void Save() => _context.DbDispose();

    public List<TModel> GetAll()
    {
        var result = Table.FindAll().ToList();
        Save();

        return result;
    }

    public List<TModel> GetAll(Expression<Func<TModel, bool>> expression)
    {
        var result = Table.Find(expression).ToList();
        Save();

        return result;
    }

    public TModel Get(Guid id)
    {
        var result = Table.FindById(id);
        Save();

        return result;
    }

    public TModel Get(Expression<Func<TModel, bool>> expression)
    {
        var result = Table.FindOne(expression);
        Save();

        return result;
    }

    public int Count()
    {
        var result = Table.Count();
        Save();

        return result;
    }

    public int Count(Expression<Func<TModel, bool>> expression)
    {
        var result = Table.Count(expression);
        Save();

        return result;
    }


    public bool Add(TModel model)
    {
        model.CreatedDate = DateTime.Now;
        model.UpdatedDate = DateTime.Now;
        model.IsActive = true;
        var result = Table.Insert(model);
        Save();

        return result != null;
    }

    public bool Update(TModel model)
    {
        model.UpdatedDate = DateTime.Now;
        var result = Table.Update(model);
        Save();

        return result;
    }

    public bool Delete(Guid id)
    {
        var result = Table.Delete(id);
        Save();

        return result;
    }

    public bool Delete(Expression<Func<TModel, bool>> expression)
    {
        var model = Get(expression);
        var result = Delete(model.Id);

        return result;
    }



    public string UploadFile(string fileName, byte[] data)
    {
        var info = Storage.Upload(Guid.NewGuid().ToString(), fileName, new MemoryStream(data));
        Save();

        return info.Id;
    }

    public byte[] DownloadFile(string fileId)
    {
        var stream = new MemoryStream();
        Storage.Download(fileId, stream);
        stream.Position = 0;

        return stream.ToArray();
    }
}
