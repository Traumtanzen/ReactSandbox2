using Calculator.Interfaces;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class Multiply: IMultiply
    {
        public async Task Multiplying(string query, double firstValue, double secondValue)
        {
            double calculatedResult = firstValue * secondValue;
            PrepareResult prepare = new PrepareResult();
            await prepare.PreparingResult(query, calculatedResult);
        }
    }
}
