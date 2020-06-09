using System;
using System.Collections.Generic;

namespace Ideastudio.Domain
{
    public class IdejnoResenje : BaseEntity
    {
        public IdejnoResenje()
        {
            ProjektiZaGradjevinskuDozvolu = new HashSet<ProjekatZaGradjevinskuDozvolu>();
        }

        public string Naziv { get; set; }

        public DateTime DatumIzrade { get; set; }

        public int GlavniProjektantId { get; set; }

        public GlavniProjektant GlavniProjektant { get; set; }

        public int ObjekatId { get; set; }

        public Objekat Objekat { get; set; }

        public int LokacijskaDozvolaId { get; set; }

        public LokacijskaDozvola LokacijskaDozvola { get; set; }

        public virtual ICollection<ProjekatZaGradjevinskuDozvolu> ProjektiZaGradjevinskuDozvolu { get; set; }
    }
}
