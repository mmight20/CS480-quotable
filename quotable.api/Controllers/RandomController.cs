using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quotable.core;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace quotable.api.Controllers
{
    [Route("api/[controller]")]
    public class RandomController : Controller
    {
        ///add a SimpleRandomQuoteProvider object to access its methods
        SimpleRandomQuoteProvider simple = new SimpleRandomQuoteProvider(); 

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Random rand = new Random();
            int num = rand.Next(1, 4);
            return simple.getSingleQuote(num);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
