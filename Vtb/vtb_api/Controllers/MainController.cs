using System.Web.Http.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vtb_api.Classes;

namespace vtb_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        [Route("api/getdatasets")]
        [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
        [AllowCrossSiteJson]
        [HttpGet]
        public ActionResult<string> GetDatasets()
        {


            return Ok("success");
        }
    }
}
