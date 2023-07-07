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
    public class CategoryController : ControllerBase
    {

        private readonly IProductResource productResource;
        public CategoryController(IProductResource productResource)
        {
            this.productResource = productResource;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public IList<Category> Get()
        {
            return this.productResource.CatList();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
