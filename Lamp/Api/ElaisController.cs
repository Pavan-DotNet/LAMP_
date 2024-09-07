using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataModel;
using Lamp.Repo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lamp.Api
{

    [Produces("application/json")]
    [Route("api/elais")]
    public class ElaisController : Controller
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment environment;

        public ElaisController(Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
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

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await EliasRepo.GetById(id);
            return Ok(response);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TcProfileForm data)
        {
            var response = await EliasRepo.Save(data);
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

        // GET: api/profiling/Filter
        [HttpPost("SavePdf", Name = "SavePdf")]
        public async Task<IActionResult> SavePDF([FromBody] SendMailModel data)
        {
            try
            {
                //var pdfBinary = Convert.FromBase64String(data[0]);

                var encryptedURl = "https://lampd-ext.juniper.net" + Url.Action("Review", "Forms", new { SecureInt = data.Encrypted });

                string Email = string.Empty;

                using (var AppContext = new legal_dbContext())
                {
                    int Id = Convert.ToInt32(data.Id);
                    TcProfileForm Result = await EliasRepo.GetById(Id);

                    Email = Result.SubEmail;

                    await EliasRepo.SaveAttachmentURLAsync(Id, Email, encryptedURl);

                    ////Result.Document = pdfBinary;
                    //Result.EliasCopy = encryptedURl;
                    //AppContext.Update(Result);
                    //AppContext.SaveChanges();

                }

                SendMail.sendUsingSmtp(encryptedURl, Email, data.Id);
                return Ok("Mail Sent");

            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }
    }
}

public class SendMailModel
{
    public int Id { get; set; }
    public String Encrypted { get; set; }
    public string End_User_Email { get; set; }
    public string Channel_User_Email { get; set; }
}
