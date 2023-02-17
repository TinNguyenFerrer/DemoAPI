using DemoAPI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using static System.Reflection.Metadata.BlobBuilder;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DemoAngu_DBContext _DBContext;

        public ProductController(DemoAngu_DBContext dBContext)
        {
            _DBContext = dBContext;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_DBContext.Products.ToList());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_DBContext.Products.Find(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            _DBContext.Add(product);
            _DBContext.SaveChanges();
            return Ok();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            _DBContext.Products.Attach(product);
            _DBContext.Entry(product).State = EntityState.Modified;
            _DBContext.SaveChanges();
            return Ok();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var exit = _DBContext.Products.Find(id);
            if(exit != null)
            {
                _DBContext.Remove(exit);
                _DBContext.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
    }

}
