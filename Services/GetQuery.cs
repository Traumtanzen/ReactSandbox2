﻿using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class GetQuery : IGetQuery
    {
        public async Task GettingQuery(string query)
        {
            query.Trim().ToLower();
            IProcessQuery process = new ProcessQuery();
            await process.ProcessingQuery(query);
        }
    }
}
