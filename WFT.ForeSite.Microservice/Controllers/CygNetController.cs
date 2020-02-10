using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WFT.ForeSite.Utility.BusinessManager;
using WFT.ForeSite.Utility.Comman.Interface;
using WFT.ForeSite.Utility.Comman.Model;
using WFT.ForeSite.Utility.Comman.Model.ResponseModel;

namespace WFT.ForeSite.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CygNetController : ControllerBase
    {
        // GET: api/CygNet
        [HttpGet]
        public IEnumerable<string> GetDomain()
        {
            return new string[] { "9077", "9051" };

        }

        // GET: api/CygNet/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CygNet
        [HttpPost]
        public CygnetResponseModel GetCygNetConnectivity([FromBody] ICygNetModel cygNetModel)
        {
            CygnetResponseModel cygnetResponseModel = new CygnetResponseModel();
            CygNetBusinessManager cygNetBusinessManager = new CygNetBusinessManager();
            try
            {
                cygnetResponseModel.IsCygNetConnected = cygNetBusinessManager.GetUisClient(cygNetModel) == null ? true : false;
            }
            catch (Exception error)
            {
                cygnetResponseModel.Error = error.Message;
            }

            return cygnetResponseModel;
        }

        // PUT: api/CygNet/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
