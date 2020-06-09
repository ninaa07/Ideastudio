using System;
using System.Collections.Generic;
using System.Text;

namespace Ideastudio.Domain
{
    public class InformacijeOLokaciji : BaseEntity
    {
        public InformacijeOLokaciji()
        {
            LokacijskeDozvole = new HashSet<LokacijskaDozvola>();
        }

        public DateTime DatumIzdavanja { get; set; }

        public string NamenaZemljista { get; set; }

        public string Zona { get; set; }

        public virtual ICollection<LokacijskaDozvola> LokacijskeDozvole { get; set; }
    }
}
