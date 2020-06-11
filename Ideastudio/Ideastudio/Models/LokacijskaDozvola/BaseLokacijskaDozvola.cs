using System;

namespace Ideastudio.Models.LokacijskaDozvola
{
    public class BaseLokacijskaDozvola
    {
        public string OpstiPodaci { get; set; }

        public string LokacijskiUslovi { get; set; }

        public long BrojParcele { get; set; }

        public long PovrsinaParcele { get; set; }

        public DateTime DatumIzdavanja { get; set; }

        public int InformacijeOLokacijiId { get; set; }

        public string NazivIdejnogResenja { get; set; }
    }
}
