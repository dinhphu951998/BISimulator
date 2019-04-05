using BISimulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BISimulator.ViewModels
{
    public class RequestFusionViewModel
    {
        public string ConnectionString { get; set; }

        public List<Field> Fields { get; set; }

        public string Table { get; set; }

    }
}
