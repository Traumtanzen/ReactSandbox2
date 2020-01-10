using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface ICos
    {
        public Task CalculateCos(string query, double firstValue);
    }
}
