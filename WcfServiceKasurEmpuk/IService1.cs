using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceKasurEmpuk
{
    [ServiceContract]
    public interface IService1 
    {
        [OperationContract]
        IEnumerable<HotelEmpuk> GetHotelEmpuks();
        [OperationContract]
        void insertHotelEmpuk(HotelEmpuk empuk);
        [OperationContract]
        void updateHotelEmpuk(HotelEmpuk empuk);
        [OperationContract]
        void deleteHotelEmpuk(int id_pemesanan);
    }

    [DataContract]
    public class HotelEmpuk
    {
        [DataMember]
        [Key]
        [Required]
        public int id_pemesanan { get; set; }
        [DataMember]
        public int status { get; set; }
        [DataMember]
        public string tanggal_pemakaian { get; set; }
        [DataMember]
        public string tanggal_selesai { get; set; }
        [DataMember]
        public string nama_hotel { get; set; }
    }
}
