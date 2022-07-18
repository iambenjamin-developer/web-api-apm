using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAPM.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiAPM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly BusinessDbContext _context;

        public ProductsController(BusinessDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public ActionResult Get()
        {
            var result = _context.Products.ToList();
            return Ok(result);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public ActionResult Post([FromBody] Product product)
        {
            var entity = new Product
            {
                Name = product.Name,
                Stock = 1
            };

            _context.Products.Add(entity);
            _context.SaveChanges();

            return Created("OK", entity);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
