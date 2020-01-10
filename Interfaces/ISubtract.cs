using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface ISubtract
    {
        public Task Subtracting(string query, double firstValue, double secondValue);
    }
}
