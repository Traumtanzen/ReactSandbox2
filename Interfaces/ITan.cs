using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface ITan
    {
        public Task CalculateTan(string query, double firstValue);
    }
}
