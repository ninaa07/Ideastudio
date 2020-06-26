using System.Collections.Generic;

namespace Ideastudio.Domain
{
    public class VrstaPovrsine : BaseEntity
    {
        public VrstaPovrsine()
        {
            Prostorije = new HashSet<Prostorija>();
            //Povrsine = new HashSet<Povrsina>();
        }

        public string Naziv { get; set; }

        public virtual ICollection<Prostorija> Prostorije { get; set; }

        //public virtual ICollection<Povrsina> Povrsine { get; set; }
    }
}
