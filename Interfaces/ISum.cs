using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface ISum
    {
        public Task Summing(string query, double firstValue, double secondValue);
    }
}
