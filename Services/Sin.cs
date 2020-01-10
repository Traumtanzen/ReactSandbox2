using System;
using System.Threading.Tasks;
using Calculator.Interfaces;

namespace Calculator.Services
{
    public class Sin: ISin
    {
        public async Task CalculateSin(string query, double firstValue)
        {
            double calculatedResult = Math.Sin(firstValue);
            PrepareResult prepare = new PrepareResult();
            await prepare.PreparingResult(query, calculatedResult);
        }
    }
}
