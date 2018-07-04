using Cibertec.Repository;

namespace Cibertec.UnitOfWork
{
    public interface IUnitOfwork
    {
        IProductoRepository Producto { get; }
        //mas repos
    }
}
