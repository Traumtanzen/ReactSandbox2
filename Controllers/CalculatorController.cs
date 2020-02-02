using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Calculator.Services;
using ReactSandbox2.Models;

namespace ReactSandbox2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        public async Task<string> Post([FromBody] CalcModel query)
        {
            GetQuery process = new GetQuery();
            var result = await process.GettingQuery(query.Query);
            return result;
        }

    }
}
