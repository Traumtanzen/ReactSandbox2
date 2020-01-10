using System;
using Calculator.Interfaces;
using System.Threading.Tasks;
using ReactSandbox2;

namespace Calculator.Services
{
    public class PrepareResult: IPrepareResult
    {

        public string MyResult { get; set; }

        public async Task<string> PreparingResult(string query, double calculatedResult)
        {
            var resultToSave = new CalculationData();
            resultToSave.UserQuery = query;
            resultToSave.CalculationResult = calculatedResult;
            resultToSave.OperationTime = DateTime.Now;

            var save = new SaveResult();
            await save.SavingResult(resultToSave);
            return MyResult = calculatedResult.ToString();
        }
    }
}
