using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class Cos: ICos
    {
        public async Task CalculateCos(string query, double firstValue)
        {
            double calculatedResult = Math.Cos(firstValue);
            PrepareResult prepare = new PrepareResult();
            await prepare.PreparingResult(query, calculatedResult);
        }
    }
}
