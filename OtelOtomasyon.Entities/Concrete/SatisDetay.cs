using System;
using System.Collections.Generic;

#nullable disable

namespace OtelOtomasyon.Entities.Concrete
{
    public partial class SatisDetay
    {
        public int SatisId { get; set; }
        public int UrunId { get; set; }
        public double? Miktar { get; set; }
    }
}
