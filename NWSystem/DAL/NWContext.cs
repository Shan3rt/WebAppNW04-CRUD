using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity; //inheritance of DbContext from EntityFramework
using NWSystem.ENTITIES;

namespace NWSystem.DAL
{
    internal class NWContext : DbContext
    {
        public NWContext() : base("NWDB")
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}