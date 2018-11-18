using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EPandit.Repository.Infrastructure
{
    public interface IRepository<T> : IDisposable
    {
        T FindById(int id);                

        void Add(T newEntity);

        void Delete(T entity);

        void Update(T entity);

        int Save();

        IQueryable<T> Where(Expression<Func<T, bool>> criteria);
                
        Task<int> SaveAsync();
    }
}