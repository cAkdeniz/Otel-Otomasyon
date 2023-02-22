using System;
using System.Collections.Generic;

#nullable disable

namespace OtelOtomasyon.Entities.Concrete
{
    public partial class SatinAlmaDetay
    {
        public int SatinAlmaId { get; set; }
        public int UrunId { get; set; }
        public double? Miktar { get; set; }
        public decimal? AlisFiyat { get; set; }
    }
}
