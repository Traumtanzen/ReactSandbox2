using System;

namespace ReactSandbox2
{
    public class PreparedResult : BaseEntity
    {
        public string UserQuery { get; set; }
        public string CalculationResult { get; set; }
        public string OperationTime { get; set; }
    }
}
