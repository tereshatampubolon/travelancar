using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceKasurEmpuk;

namespace WcfServiceKasurEmpukss
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void deleteHotelEmpuk(int id_pemesanan)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HotelEmpuk> GetHotelEmpuks()
        {
            throw new NotImplementedException();
        }

        public void insertHotelEmpuk(HotelEmpuk empuk)
        {
            EmpukContext ep = new EmpukContext();
            ep.HotelEmpuks.Add(empuk);
            ep.SaveChanges();
        }

        public void updateHotelEmpuk(HotelEmpuk empuk)
        {
            throw new NotImplementedException();
        }
    }
}
