using System.Threading.Tasks;
using Lamp.Models;
using Lamp.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lamp.Api
{
    [Route("api/[controller]")]
    public class SwdlController : ControllerBase
    {
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<SwdlForm> Get(int id)
        {
            var response = await SwdlRepo.GetById(id);
            return response;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<SwdlForm> Post([FromBody] SwdlForm data)
        {
            var response = await SwdlRepo.Save(data);
            return response;
        }

        // POST api/<controller>
        [HttpPost("SendMail", Name = "SendMail")]
        public async Task<string> SendMail([FromBody] SendMailModel data)
        {
            var encryptedURl = "https://lampd-ext.juniper.net" + Url.Action("Swdl_Preview", "Forms", new { SecureInt = data.Encrypted });
            var response = await SwdlRepo.SendMail(data, encryptedURl);
            return response;
        }
    }
}
