using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface ISum
    {
        public Task<string> Summing(string query, double firstValue, double secondValue);
    }
}
