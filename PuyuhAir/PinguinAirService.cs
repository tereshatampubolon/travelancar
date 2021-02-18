using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PuyuhAir
{
    [ServiceContract]
    public interface PuyuhAirService
    {
        [OperationContract]
        IEnumerable<tiket> GetTiket();
        [OperationContract]
        void insert(tiket Tiket);
    }

    [DataContract]
    public class tiket
    {
        [Key]
        [Required]
        [DataMember]
        public int id { get; set; }
        [Required]
        [DataMember]
        public int id_user { get; set; }
        [Required]
        [DataMember]
        public int id_pesawat { get; set; }
        [Required]
        [DataMember]
        public int asal { get; set; }
        [Required]
        [DataMember]
        public int tujuan { get; set; }
        [Required]
        [DataMember]
        public decimal harga  { get; set; }
        [Required]
        [DataMember]
        public string tanggal { get; set; }
    }
}
