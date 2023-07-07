using InterviewCodeChallenge_React.Models;
using InterviewCodeChallenge_React.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace InterviewCodeChallenge_React.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductResource productResource;

        public ProductController(IProductResource productResource)
        {
            this.productResource = productResource;

        }

        // GET: api/<ProductController>
        [HttpGet]
        public ProductCollection Get()
        {
            return this.productResource.List();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public ProductDetail Post([FromBody] ProductDetail product)
        {
            return this.productResource.AddProduct(product);
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
