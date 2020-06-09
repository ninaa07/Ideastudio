using System;
using System.Collections.Generic;
using System.Text;

namespace Ideastudio.Domain
{
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
    }
}
