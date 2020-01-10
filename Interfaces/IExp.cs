using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface IExp
    {
        public Task CalculateExp(string query, double firstValue, double secondValue);
    }
}
