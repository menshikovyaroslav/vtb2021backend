using System.Web.Http.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vtb_api.Classes;
using vtb_api.Data;
using vtb_api.Models;

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
            var datasets = DataBase.GetDatasets();
            return Ok(datasets);
        }

        [Route("api/getdatasetbyid")]
        [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
        [AllowCrossSiteJson]
        [HttpGet]
        public ActionResult<string> GetDatasetById(int id)
        {
            //var dataset = DataBase.GetDatasets();
            return Ok(new WorkDataset());
        }
    }
}
