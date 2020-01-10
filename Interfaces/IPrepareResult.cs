using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface IPrepareResult
    {
        public Task<string> PreparingResult(string query, double calculatedResult);
    }
}
