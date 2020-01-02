using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ReactSandbox2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<PreparedResult> Get()
        {
            List<PreparedResult> calcList = new List<PreparedResult>();
            using (var context = new CalculatorContext())
            {
                foreach (var entry in context.LogFile)
                {
                    PreparedResult getEntry = new PreparedResult
                    {
                        Id = entry.Id,
                        UserQuery = entry.UserQuery,
                        CalculationResult = entry.CalculationResult.ToString(),
                        OperationTime = entry.OperationTime.ToString()
                    };
                    calcList.Add(getEntry);
                }
            }
            return calcList;
        }
    }
}
