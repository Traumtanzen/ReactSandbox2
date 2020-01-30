using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Calculator.Services;

namespace ReactSandbox2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        public async Task Post(string query)
        {
            GetQuery process = new GetQuery();
            await process.GettingQuery(query);
        }

        [HttpGet]
        public string Process()
        {
            PrepareResult result = new PrepareResult();
            return result.MyResult;
        }
    }
}
