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
    /// <summary>
    /// Основной контроллер API
    /// </summary>
    public class MainController : Controller
    {
        [Route("api/getdatasets")]
        [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
        [AllowCrossSiteJson]
        [HttpGet]
        public ActionResult<string> GetDatasets()
        {
            var result = new List<string>() { "tst"};

            return Ok(result);
        }
    }
}
