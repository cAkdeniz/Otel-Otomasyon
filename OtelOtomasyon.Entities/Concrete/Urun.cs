using System;
using System.Collections.Generic;

#nullable disable

namespace OtelOtomasyon.Entities.Concrete
{
    public partial class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public decimal? Fiyat { get; set; }
        public double? Miktar { get; set; }
        public int? KategoriId { get; set; }
        public int? BirimTipId { get; set; }
        public bool? Aktif { get; set; } = true;
    }
}
