using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace EntityFreamworkDemo
{
    class ETradeContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
