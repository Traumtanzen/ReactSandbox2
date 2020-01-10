using System;
using Calculator.Interfaces;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class Tan: ITan
    {
        public async Task CalculateTan(string query, double firstValue)
        {
            double calculatedResult = Math.Tan(firstValue);
            PrepareResult prepare = new PrepareResult();
            await prepare.PreparingResult(query, calculatedResult);
        }
    }
}
