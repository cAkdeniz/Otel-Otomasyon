using System;
using System.Collections.Generic;

#nullable disable

namespace OtelOtomasyon.Entities.Concrete
{
    public partial class KasaHareket
    {
        public int Id { get; set; }
        public int? KasaId { get; set; }
        public int? KasaHareketTipId { get; set; }
        public decimal? Tutar { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
