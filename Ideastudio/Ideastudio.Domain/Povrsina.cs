namespace Ideastudio.Domain
{
    public enum Status
    {
        Insert, 
        Update, 
        Delete
    }

    public class Povrsina : BaseEntity
    {
        public int Oznaka { get; set; }

        public string Naziv { get; set; }

        public string VrstaPoda { get; set; }

        public int ProjekatZaGradjevinskuDozvoluId { get; set; }

        public ProjekatZaGradjevinskuDozvolu ProjekatZaGradjevinskuDozvolu { get; set; }

        public int VrstaPovrsineId { get; set; }

        public VrstaPovrsine VrstaPovrsine { get; set; }

        public Status Status { get; set; }
    }
}
