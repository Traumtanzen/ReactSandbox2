using ReactSandbox2;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface ISaveResult
    {
        public Task SavingResult(CalculationData resultToSave);
    }
}
