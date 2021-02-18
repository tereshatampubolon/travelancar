using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PuyuhAir
{
    public class Service1 : PuyuhAirService
    {
        public IEnumerable<tiket> GetTiket()
        {
            List<tiket> li = new List<tiket>();
            PesawatContext po = new PesawatContext();
            li = po.tikets.ToList();
            return li;
        }

        public void insert(tiket Tiket)
        {
            PesawatContext pc = new PesawatContext();
            pc.tikets.Add(Tiket);
            pc.SaveChanges();
        }
    }
}
