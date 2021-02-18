using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HotelMelatiService
{
    public class Service1 : HotelMelati
    {
        public IEnumerable<Hotel> GetHotels()
        {
            List<Hotel> li = new List<Hotel>();
            HotelContext po = new HotelContext();
            li = po.Hotels.ToList();
            return li;
        }

        public void insertHotel(Hotel hotel)
        {
            HotelContext hc = new HotelContext();
            hc.Hotels.Add(hotel);
            hc.SaveChanges();
        }
    }
}
