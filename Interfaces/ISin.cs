using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface ISin
    {
        public Task CalculateSin(string query, double firstValue);
    }
}
