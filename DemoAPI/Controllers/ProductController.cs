using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static System.Reflection.Metadata.BlobBuilder;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Product[] product = new Product[] {
                new Product(2, "Biographies & Memoirs", "Biographies & Memoirs", 2),
                new Product(1, "Art & Photography", " All kinds of books related to business and investing: management, finance, entrepreneurs, startup, skills, sales, etc.", 32),
                new Product(31, "How-to - Self Help","dsds" , 36)

            };
            var t = product.ToList();

            return Ok(product);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}
