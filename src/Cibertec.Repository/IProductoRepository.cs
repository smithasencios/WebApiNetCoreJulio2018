using Cibertec.Models;
using System.Collections.Generic;

namespace Cibertec.Repository
{
    public interface IProductoRepository : IRepository<Producto>
    {
        IEnumerable<Producto> GetProductosMayorVentaHoy();
        //..puedo crear mas metodos....
    }
}
