using StormShop.API.Data;
using StormShop.API.Interfaces;
using StormShop.API.Models;

namespace StormShop.API.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryModel<T> where T : class
    {
        private AplicationContext context;

        public RepositoryBase(AplicationContext context)
        {
            this.context = context;
        }

        public void Create(T entity)
        {
            this.context.Set<T>().Add(entity);
        }

        public IEnumerable<T> ReadAll()
        {
            return this.context.Set<T>().ToList();
        }

        public T FindById(int id)
        {
            return this.context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }

        public void DeleteById(int id)
        {
            var entity = FindById(id);
            Delete(entity);
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public void SaveChanges(T entity)
        {
            this.context.SaveChanges();
        }
    }
}
