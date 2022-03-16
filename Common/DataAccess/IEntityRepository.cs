using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.DataAccess
{
    public interface IEntityRepository<T> where T : class, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        T GetFirst(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        bool Any(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void AddRange(List<T> entites);
        void Update(T entity);
        void UpdateRange(List<T> entites);
        void Delete(T entity);
    }
}
