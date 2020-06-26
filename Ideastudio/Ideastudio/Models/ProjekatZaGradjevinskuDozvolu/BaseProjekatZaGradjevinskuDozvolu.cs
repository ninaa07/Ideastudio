using Ideastudio.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ideastudio.Models.ProjekatZaGradjevinskuDozvolu
{
    public class BaseProjekatZaGradjevinskuDozvolu
    {
        public string Naziv { get; set; }

        public DateTime DatumIzrade { get; set; }

        public string NazivIdejnogResenja { get; set; }

        public int IdejnoResenjeId { get; set; }

        public virtual ICollection<Povrsina> Povrsine { get; set; }

        public StatusDokumenta StatusDokumenta { get; set; }
    }
}
