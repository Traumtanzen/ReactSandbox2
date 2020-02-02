using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface IProcessQuery
    {
        public Task<string> ProcessingQuery(string rawQuery);
    }
}
