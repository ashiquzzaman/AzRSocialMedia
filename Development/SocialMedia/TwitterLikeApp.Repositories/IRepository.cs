using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TwitterLikeApp.Repositories
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IQueryable<T> All();
        bool Any(Expression<Func<T, bool>> predicate);

        T Find(params object[] keys);
        T Find(Expression<Func<T, bool>> predicate);

        IQueryable<T> FindAll(Expression<Func<T, bool>> predicate);
        IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, int index, int size);
        int Count { get; }

        T Create(T t);

        int Update(T t);
        int Update(Expression<Func<T, bool>> predicate);

        int Delete(T t);
        int Delete(Expression<Func<T, bool>> predicate);
    }
}
