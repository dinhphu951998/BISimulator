using System;
using System.Collections.Generic;

namespace BISimulator.Models
{
    public partial class Connection
    {
        public Connection()
        {
            Table = new HashSet<Table>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Table> Table { get; set; }
    }
}
