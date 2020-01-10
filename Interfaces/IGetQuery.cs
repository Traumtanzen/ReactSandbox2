using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface IGetQuery
    {
        public Task GettingQuery(string query);
    }
}
