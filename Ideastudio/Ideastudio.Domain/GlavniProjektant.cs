using System;
using System.Collections.Generic;
using System.Text;

namespace Ideastudio.Domain
{
    public class GlavniProjektant : BaseEntity
    {
        public GlavniProjektant()
        {
            IdejnaResenja = new HashSet<IdejnoResenje>();
        }

        public string ImePrezime { get; set; }

        public long BrojLicence { get; set; }

        public string Zvanje { get; set; }

        public virtual ICollection<IdejnoResenje> IdejnaResenja { get; set; }
    }
}
