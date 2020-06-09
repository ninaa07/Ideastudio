using System.Collections.Generic;

namespace Ideastudio.Domain
{
    public class Objekat : BaseEntity
    {
        public Objekat()
        {
            IdejnaResenja = new HashSet<IdejnoResenje>();
        }

        public long BrojParcele { get; set; }

        public string Naziv { get; set; }

        public virtual ICollection<IdejnoResenje> IdejnaResenja { get; set; }
    }
}
