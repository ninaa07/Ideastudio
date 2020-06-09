using System;
using System.Collections.Generic;
using System.Text;

namespace Ideastudio.Domain
{
    public class Povrsina : BaseEntity
    {
        public int Oznaka { get; set; }

        public string VrstaPoda { get; set; }

        public int ProjekatZaGradjevinskuDozvoluId { get; set; }

        public ProjekatZaGradjevinskuDozvolu ProjekatZaGradjevinskuDozvolu { get; set; }

        public int VrstaPovrsineId { get; set; }

        public VrstaPovrsine VrstaPovrsine { get; set; }
    }
}
