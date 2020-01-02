using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactSandbox2
{
    public class CalculationData : BaseEntity
    {
        public string UserQuery { get; set; }
        public double CalculationResult { get; set; }
        public DateTime OperationTime { get; set; }
    }
}
