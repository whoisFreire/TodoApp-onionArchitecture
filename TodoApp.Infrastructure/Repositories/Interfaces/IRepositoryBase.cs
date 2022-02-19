using System.Collections.Generic;
using TodoApp.Domain.Models;

namespace TodoApp.Infrastructure.Repositories.Interfaces
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(string id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
