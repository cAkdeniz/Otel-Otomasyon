using System;
using System.Collections.Generic;

#nullable disable

namespace OtelOtomasyon.Entities.Concrete
{
    public partial class Oda
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string? Aciklama { get; set; }
        public int OdaTurId { get; set; }
        public bool? Aktif { get; set; } = true;
    }
}
