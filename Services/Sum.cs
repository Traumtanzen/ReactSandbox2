using Calculator.Interfaces;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class Sum: ISum
    {
        public async Task<string> Summing(string query, double firstValue, double secondValue)
        {
            double calculatedResult = firstValue + secondValue;
            PrepareResult prepare = new PrepareResult();
            return await prepare.PreparingResult(query, calculatedResult);
        }
    }
}
