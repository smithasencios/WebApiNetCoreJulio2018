using System.Collections.Generic;

namespace Cibertec.Repository
{
    public interface IRepository<T> where T : class
    {
        int Delete(T entity);
        int Update(T entity);
        int Insert(T entity);
        IEnumerable<T> GetList();
        T GetById(int id);
    }
}
