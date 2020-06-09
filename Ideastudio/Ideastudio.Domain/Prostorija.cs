using System;
using System.Collections.Generic;
using System.Text;

namespace Ideastudio.Domain
{
    public class Prostorija : BaseEntity
    {
        public string Naziv { get; set; }

        public int VrstaPovrsineId { get; set; }

        public VrstaPovrsine VrstaPovrsine { get; set; }
    }
}
