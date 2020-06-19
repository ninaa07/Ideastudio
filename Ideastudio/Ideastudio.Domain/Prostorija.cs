using System.Collections;
using System.Collections.Generic;

namespace Ideastudio.Domain
{
    public class Prostorija : BaseEntity
    {
        public string Naziv { get; set; }

        public int VrstaPovrsineId { get; set; }

        public VrstaPovrsine VrstaPovrsine { get; set; }
    }
}
