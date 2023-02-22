using System;
using System.Collections.Generic;

#nullable disable

namespace OtelOtomasyon.Entities.Concrete
{
    public partial class Personel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcKn { get; set; }
        public string TelNo { get; set; }
        public string Adres { get; set; }
        public DateTime? DogumTarih { get; set; }
        public DateTime? IseGirisTarih { get; set; }
        public decimal? Maas { get; set; }
        public bool? Aktif { get; set; } = true;
    }
}
