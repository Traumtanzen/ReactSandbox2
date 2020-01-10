using Calculator.Interfaces;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class Subtract: ISubtract
    {
        public async Task Subtracting(string query, double firstValue, double secondValue)
        {
            double calculatedResult = firstValue - secondValue;
            PrepareResult prepare = new PrepareResult();
            await prepare.PreparingResult(query, calculatedResult);
        }

    }
}
