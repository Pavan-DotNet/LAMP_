using Lamp.Models;
using Lamp.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lamp.Api
{
    [Produces("application/json")]
    [Route("api/tap/v1/")]
    public class TapController : ControllerBase
    {

        // GET api/<TapController>/
        [HttpGet]
        public List<TapPolicy> GetAsync()
        {
            var response = TapPolicyRepo.Get();
            return response;
        }

        // GET api/<TapController>/
        [HttpGet("{id}")]
        public async Task<TapPolicy> GetTap(int id)
        {
            var response = await TapPolicyRepo.GetById(id);
            return response;
        }

        // POST api/<TapController>/
        [HttpPost]
        public bool PostAsync([FromBody] TapPolicy val)
        {
            return TapPolicyRepo.Save(val);
        }

        [HttpGet("Download/{id}", Name = "Download")]
        public async Task<FileResult> Download(string id)
        {

            TapPolicy document = await TapPolicyRepo.GetByName(id);

            if (document.Policy_FinalVersion == null)
                document.Policy_FinalVersion = "";

            byte[] doc = Convert.FromBase64String(document.Policy_FinalVersion);
            return File(doc, "application/octet-stream", "download.docx");

        }
    }
}