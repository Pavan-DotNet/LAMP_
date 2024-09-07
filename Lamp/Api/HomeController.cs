using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModel;
using Lamp.Logger;
using Lamp.Repo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace Lamp.Api
{
    [Authorize]
    [ServiceFilter(typeof(LogFilter))]
    [Produces("application/json")]
    [Route("api/home")]
    public class HomeController : Controller
    {
        // GET: api/home
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/home/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/home
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/home/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/home/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        
    }
}
