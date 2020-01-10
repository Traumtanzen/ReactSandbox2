using System;
using Calculator.Interfaces;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class Exp: IExp
    {
        public async Task CalculateExp(string query, double firstValue, double secondValue)
        {
            double calculatedResult = Math.Pow(firstValue, secondValue);
            PrepareResult prepare = new PrepareResult();
            await prepare.PreparingResult(query, calculatedResult);
        }
    }
}
