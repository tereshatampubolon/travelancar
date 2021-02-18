using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PuyuhAir
{
    public class PesawatContext : DbContext
    {
        public DbSet<tiket> tikets { get; set; }
        public PesawatContext() : base("PinguinAir")
        { 

        }
    }
}