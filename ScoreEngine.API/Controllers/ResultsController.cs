using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScoreEngine.API.Data;

namespace ScoreEngine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        // GET
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var dbHelper = new DbHelperService();
                return Ok(dbHelper.GetScoreData());
            }
            catch (Exception EX)
            {
                return Problem(EX.ToString());
            }
        }

        // POST
        [HttpPost]
        public ActionResult Post(string name, int score)
        {
            try
            {
                var dbHelper = new DbHelperService();
                return Ok(dbHelper.AddScoreData(name, score));
            }
            catch (Exception EX)
            {
                return Problem(EX.ToString());
            }
        }
    }
}