using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HotelEmpukService
{
    [ServiceContract]
    public interface HoteEmpuk
    {
        [OperationContract]
        IEnumerable<Hotel> GetHotels();
        [OperationContract]
        void insertHotel(Hotel hotel);
    } 

    [DataContract]
    public class Hotel
    {
        [Key]
        [Required]
        [DataMember]
        public int id_pemesanan { get; set; }
        [Required]
        [DataMember]
        public int status { get; set; }
        [Required]
        [DataMember]
        public string tanggal_pemakaian { get; set; }
        [Required]
        [DataMember]
        public string tanggal_selesai { get; set; }
        [Required]
        [DataMember]
        public string nama_hotel { get; set; }
    }
}
