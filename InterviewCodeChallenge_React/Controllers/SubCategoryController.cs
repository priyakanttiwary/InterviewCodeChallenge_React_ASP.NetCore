using InterviewCodeChallenge_React.Models;
using InterviewCodeChallenge_React.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InterviewCodeChallenge_React.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {

        private readonly IProductResource productResource;
        public SubCategoryController(IProductResource productResource)
        {
            this.productResource = productResource;
        }

        // GET: api/<SubCategoryController>
        [HttpGet]
        public IList<Subcategory> Get()
        {
            return this.productResource.SubCatList();
        }

        // GET api/<SubCategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SubCategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SubCategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SubCategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
