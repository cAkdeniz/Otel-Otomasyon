using System;
using System.Collections.Generic;

#nullable disable

namespace OtelOtomasyon.Entities.Concrete
{
    public partial class OdaOzellik
    {
        public int OdaId { get; set; }
        public int OzellikId { get; set; }
        public string Deger { get; set; }
    }
}
