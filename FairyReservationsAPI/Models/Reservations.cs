namespace FairyWeddings.Reservations.Models
{
    public class Reservations
    {
        public int WeddingId { get; set; }
        public string? BrideGroomNames { get; set; }
        public string? Venue { get; set; }
        public string? Date { get; set; }
        public int GuestsNo { get; set; }
        public string? MusicType { get; set; }
        public string? FlowerColor { get; set; }
        public string? Photography { get; set; }
        public string? Dresses { get; set; }
        public double Amount { get; set; }
    }
}
