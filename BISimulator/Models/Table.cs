using System;
using System.Collections.Generic;

namespace BISimulator.Models
{
    public partial class Table
    {
        public Table()
        {
            Field = new HashSet<Field>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ConnectionStringId { get; set; }

        public virtual Connection ConnectionString { get; set; }
        public virtual ICollection<Field> Field { get; set; }
    }
}
