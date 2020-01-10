using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface IMultiply
    {
        public Task Multiplying(string query, double firstValue, double secondValue);
    }
}
