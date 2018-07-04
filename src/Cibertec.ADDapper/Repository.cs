using Cibertec.Repository;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Cibertec.ADDapper
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly string _connectionString;
        public Repository(string connectionString)
        {
            SqlMapperExtensions.TableNameMapper = (type) => { return $"{type.Name}"; };
            _connectionString = connectionString;
        }
        public int Delete(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Delete(entity) ? 1 : 0;
            }
        }

        public T GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Get<T>(id);
            }
        }

        public IEnumerable<T> GetList()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.GetAll<T>();
            }
        }

        public int Insert(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return (int)connection.Insert(entity);
            }
        }

        public int Update(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Update(entity) ? 1 : 0;
            }
        }
    }
}
