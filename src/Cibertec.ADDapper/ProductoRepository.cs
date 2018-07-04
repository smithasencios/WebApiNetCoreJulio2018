using System.Collections.Generic;
using Cibertec.Models;
using Cibertec.Repository;

namespace Cibertec.ADDapper
{
    public class ProductoRepository : Repository<Producto>, 
                                      IProductoRepository
    {
        public ProductoRepository(string connectionString) :
            base(connectionString)
        {

        }

        public IEnumerable<Producto> GetProductosMayorVentaHoy()
        {
            throw new System.NotImplementedException();
        }
    }
}
