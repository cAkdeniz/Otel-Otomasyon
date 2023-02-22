using System;
using System.Collections.Generic;

#nullable disable

namespace OtelOtomasyon.Entities.Concrete
{
    public partial class Tedarikci
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SirketAdi { get; set; }
        public string TelNo { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public bool? Aktif { get; set; }
    }
}
