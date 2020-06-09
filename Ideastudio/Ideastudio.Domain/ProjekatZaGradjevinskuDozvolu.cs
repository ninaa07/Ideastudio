using System;
using System.Collections.Generic;

namespace Ideastudio.Domain
{
    public enum StatusDokumenta
    {
        Nov,
        Kreiran,
        Obradjen
    }

    public class ProjekatZaGradjevinskuDozvolu : BaseEntity
    {
        public ProjekatZaGradjevinskuDozvolu()
        {
            Povrsine = new HashSet<Povrsina>();
        }

        public string Naziv { get; set; }

        public DateTime DatumIzrade { get; set; }

        public int IdejnoResenjeId { get; set; }

        public IdejnoResenje IdejnoResenje { get; set; }

        public virtual ICollection<Povrsina> Povrsine { get; set; }

        public StatusDokumenta StatusDokumenta { get; set; }
    }
}
