using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskk.Entities.Abstract;

namespace Taskk.Repository.Abstract
{
    public interface IBaseRepository<T> where T : BaseEntity, new()
    {
        ICollection<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Save();
    }

}
