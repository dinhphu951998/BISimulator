using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BISimulator
{
    public abstract class Job
    {
        public abstract string GenerateQuery();

        public abstract List<dynamic> QueryData(string query);

        public List<dynamic> Execute()
        {
            string query = this.GenerateQuery();
            return QueryData(query);
        }
    }




}
