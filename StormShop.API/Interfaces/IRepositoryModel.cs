namespace StormShop.API.Interfaces
{
    public interface IRepositoryModel<T> where T : class
    {
        void Create(T entity);
        IEnumerable<T> ReadAll();
        T FindById(int id);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(int id);
        void SaveChanges(T entity);
    }
}
