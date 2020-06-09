using System;
using System.Collections.Generic;
using System.Text;

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
