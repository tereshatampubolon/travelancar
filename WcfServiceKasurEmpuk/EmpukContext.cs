using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WcfServiceKasurEmpuk
{
    public class EmpukContext : DbContext
    {
        public DbSet<HotelEmpuk> HotelEmpuks { get; set; }
        public EmpukContext() : base("HotelEmpukCS")
        {

        }
    }
}