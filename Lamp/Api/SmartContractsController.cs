using System.Collections.Generic;
using Lamp.Repo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lamp.Api
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class SmartContractsController : ControllerBase
    {
        // GET: api/<SmartContractsController>
        [HttpGet]
        public string Get()
        {
            return  SmartContractsRepo.Get();
        }

        // GET api/<SmartContractsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SmartContractsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SmartContractsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SmartContractsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
