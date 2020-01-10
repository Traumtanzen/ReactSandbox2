using System;

namespace ReactSandbox2
{
    public class CalcResults : BaseEntity
    {
        public string UserQuery { get; set; }
        public string CalculationResult { get; set; }
        public string OperationTime { get; set; }
    }
}
