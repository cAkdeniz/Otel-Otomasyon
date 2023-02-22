using System;
using System.Collections.Generic;

#nullable disable

namespace OtelOtomasyon.Entities.Concrete
{
    public partial class SatinAlma
    {
        public int Id { get; set; }
        public int? TedarikciId { get; set; }
        public DateTime? SatinAlmaTarih { get; set; }
        public int? PersonelId { get; set; }
    }
}
