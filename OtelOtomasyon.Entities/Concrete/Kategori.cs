using System;
using System.Collections.Generic;

#nullable disable

namespace OtelOtomasyon.Entities.Concrete
{
    public partial class Kategori
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public bool? Aktif { get; set; } = true;
    }
}
