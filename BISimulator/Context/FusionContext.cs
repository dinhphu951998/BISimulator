using BISimulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BISimulator.Context
{
    public class FusionContext
    {
        public List<Field> Fields { get; set; }
        public Connection Connection { get; set; }
        public Table Table { get; set; }

    }
}
