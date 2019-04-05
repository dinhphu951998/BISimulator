using System;
using System.Collections.Generic;

namespace BISimulator.Models
{
    public partial class Field
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TableId { get; set; }
        public string Datatype { get; set; }

        public virtual Table Table { get; set; }
    }
}
