using System.Collections.Generic;

namespace Ideastudio.Domain
{
    public class Objekat : BaseEntity
    {
        public Objekat()
        {
            IdejnaResenja = new HashSet<IdejnoResenje>();
        }

        public string Naziv { get; set; }

        public decimal Dimenzije { get; set; }

        public string Karakteristike { get; set; }

        public virtual ICollection<IdejnoResenje> IdejnaResenja { get; set; }
    }
}
