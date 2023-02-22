using System;
using System.Collections.Generic;

#nullable disable

namespace OtelOtomasyon.Entities.Concrete
{
    public partial class Satis
    {
        public int Id { get; set; }
        public int? MusteriId { get; set; }
        public int? PersonelId { get; set; }
        public int? OdaId { get; set; }
        public DateTime? SatisTarih { get; set; } = DateTime.Now;
    }
}
