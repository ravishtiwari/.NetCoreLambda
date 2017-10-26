using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OpenApiNetCore.Controllers
{
    [Route("api/")]
    public class IndexController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var name = "";
            var dN = new Microsoft.Extensions.Primitives.StringValues("");
            try
            {
               HttpContext.Request.Query.TryGetValue("name", out dN);
                name = dN.ToString();
            } catch (ArgumentNullException ane)
            {
                
            }

            var message = "Hello " + name;
            return new string[] { message };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
