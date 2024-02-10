using Microsoft.EntityFrameworkCore;
using Taskk.Context;
using Taskk.Entities.Abstract;
using Taskk.Repository.Abstract;

namespace Taskk.Repository.Concretes
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity,new()
    {
        internal readonly LibraryContext libraryContext;
        internal readonly DbSet<T> entity;

        public BaseRepository()
        {
            libraryContext = new LibraryContext();
            entity = libraryContext.Set<T>();
        }
        public void Add(T entity)
        {
            if (entity == null) throw new Exception("entity is null");
            this.entity.Add(entity);
        }

        public ICollection<T> GetAll()
        {
            return this.entity.ToList();

        }

        public void Remove(T entity)
        {
            if (entity == null) throw new Exception("entity is null");
           var check=libraryContext.Set<T>().FirstOrDefault(x=>x.Id==entity.Id);  
            if (check != null)
                libraryContext.Remove(entity);
        }

        public void Save()
        {
           libraryContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null) throw new Exception("entity is null");
            var check = libraryContext.Set<T>().FirstOrDefault(x => x.Id == entity.Id);
            if (check != null)
                libraryContext.Update(entity);
        }
    }
}
