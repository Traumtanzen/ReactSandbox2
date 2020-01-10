using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface IDivide
    {
        public Task Dividing(string query, double firstValue, double secondValue);
    }
}
