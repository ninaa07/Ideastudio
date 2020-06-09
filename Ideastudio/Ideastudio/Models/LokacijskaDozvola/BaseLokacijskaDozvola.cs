using System;

namespace Ideastudio.Models.LokacijskaDozvola
{
    public class BaseLokacijskaDozvola
    {
        public long BrojParcele { get; set; }

        public long PovrsinaParcele { get; set; }

        public DateTime DatumIzdavanja { get; set; }

        public string NazivObjekta { get; set; }

        public int InformacijeOLokacijiId { get; set; }
    }
}
