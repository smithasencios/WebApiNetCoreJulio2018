using Cibertec.LogicaNegocio;
using Cibertec.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cibertec.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        private readonly IProductoLogica _logica;

        public ProductoController(IProductoLogica logica)
        {
            _logica = logica;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            return _logica.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Producto value)
        {
            _logica.Insert(value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
