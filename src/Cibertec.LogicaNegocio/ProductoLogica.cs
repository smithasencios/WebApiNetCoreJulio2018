using Cibertec.Models;
using Cibertec.UnitOfWork;
using System.Collections;
using System.Collections.Generic;

namespace Cibertec.LogicaNegocio
{
    public interface IProductoLogica
    {
        IEnumerable<Producto> GetAll();
        int Insert(Producto entity);
    }

    public class ProductoLogica : IProductoLogica
    {
        private readonly IUnitOfwork _unitOfWork;

        public ProductoLogica(IUnitOfwork unitOfwork)
        {
            _unitOfWork = unitOfwork;
        }

        public IEnumerable<Producto> GetAll() => _unitOfWork.Producto.GetList();
        public int Insert(Producto entity) => _unitOfWork.Producto.Insert(entity);
    }
}
