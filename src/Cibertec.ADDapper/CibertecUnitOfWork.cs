using Cibertec.Repository;
using Cibertec.UnitOfWork;

namespace Cibertec.ADDapper
{
    public class CibertecUnitOfWork : IUnitOfwork
    {
        public CibertecUnitOfWork(string connectionString)
        {
            Producto = new ProductoRepository(connectionString);
        }
        public IProductoRepository Producto { get; private set; }

    }
}
