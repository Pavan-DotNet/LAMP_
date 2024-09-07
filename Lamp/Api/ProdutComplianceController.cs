using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataModel;
using Lamp.Models;
using Lamp.Repo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lamp.Api
{

    [Produces("application/json")]
    [Route("api/ProductCompliance")]
    public class ProdutComplianceController : Controller
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment environment;

        public ProdutComplianceController(Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            this.environment = environment;
        }
        // GET: api/<controller>
        [HttpGet]
        public ActionResult Get()
        {
            string webRootPath = environment.WebRootPath;
            string contentRootPath = environment.ContentRootPath;
            var a = Environment.GetEnvironmentVariable("AppData");

            return Content(webRootPath + "\n" + contentRootPath + "\n" + a);
            //return new string[] { "value1", "value2" };
        }

        [HttpGet("GetUsers", Name = "GetUsers")]
        public async Task<ActionResult> GetUsers()
        {
            var response = await ProductComplianceRepo.GetUsers();
            return Ok(response);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await ProductComplianceRepo.GetById(id);
            return Ok(response);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductComplianceModel data)
        {
            var response = await ProductComplianceRepo.Save(data);
            return Ok(response);

        }
        // POST api/<controller>
        [HttpPost("UpdateEncyptedKey", Name = "UpdateEncyptedKey")]
        public async Task<IActionResult> Post([FromBody] UpdateKey data)
        {
            var EncryptedMail = "https://lampd-ext.juniper.net" + Url.Action("Product_Compliance_CheckList_Preview", "Forms", new { SecureInt = data.Encrypted });
            var response = await ProductComplianceRepo.UpdateEncryptedKey(data, EncryptedMail);
            return Ok(response);

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}

public class UpdateKey
{
    public string Id { get; set; }
    public string Encrypted { get; set; }
}