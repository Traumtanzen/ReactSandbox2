using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface IProcessQuery
    {
        public Task ProcessingQuery(string rawQuery);
    }
}
