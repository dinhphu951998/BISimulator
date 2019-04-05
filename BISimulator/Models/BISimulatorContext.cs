using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BISimulator.Models
{
    public partial class BISimulatorContext : DbContext
    {
        public BISimulatorContext()
        {
        }

        public BISimulatorContext(DbContextOptions<BISimulatorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Connection> Connection { get; set; }
        public virtual DbSet<Field> Field { get; set; }
        public virtual DbSet<Table> Table { get; set; }

        
    }
}
