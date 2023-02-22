using System;
using System.Collections.Generic;

#nullable disable

namespace OtelOtomasyon.Entities.Concrete
{
    public partial class Musteri
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SirketAdi { get; set; }
        public string TcNo { get; set; }
        public string TelNo { get; set; }
        public DateTime? DogumTarih { get; set; }
        public string MedeniDurum { get; set; }
        public string Cinsiyet { get; set; }
        public bool? Aktif { get; set; } = true;
    }
}
