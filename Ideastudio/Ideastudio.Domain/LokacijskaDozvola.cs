using System;
using System.Collections.Generic;

namespace Ideastudio.Domain
{
    public class LokacijskaDozvola : BaseEntity
    {
        public LokacijskaDozvola()
        {
            IdejnaResenja = new HashSet<IdejnoResenje>();
        }

        public long BrojParcele { get; set; }

        public long PovrsinaParcele { get; set; }

        public DateTime DatumIzdavanja { get; set; }

        public string NazivObjekta { get; set; }

        public int InformacijeOLokacijiId { get; set; }

        public InformacijeOLokaciji InformacijeOLokaciji { get; set; }

        public virtual ICollection<IdejnoResenje> IdejnaResenja { get; set; }
    }
}
