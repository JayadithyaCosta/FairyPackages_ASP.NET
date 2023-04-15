using System.Reflection;

namespace FairyWeddingsAPI.Data
{
    public static class ReservationsMockDataService
    {
        public static List<Models.Reservations> Reservations = new List<Models.Reservations>()
        {
            new Models.Reservations { WeddingId = 1, BrideGroomNames = "John and Mary", Venue = "Colombo", Date = "2023.06.10", GuestsNo = 200, MusicType = "DJ", FlowerColor = "Pink", Photography = "Couple Photos", Dresses = "Hire", Amount = 250000.00 },
            new Models.Reservations { WeddingId = 2, BrideGroomNames = "Romeo and Juliet", Venue = "Kandy", Date = "2024.01.20", GuestsNo = 400, MusicType = "Live Band", FlowerColor = "Purple", Photography = "Couple and Family Photos", Dresses = "Buy", Amount = 300000.00 },
            new Models.Reservations { WeddingId = 3, BrideGroomNames = "Jack and Rose", Venue = "Kegalle", Date = "2023.12.15", GuestsNo = 150, MusicType = "DJ", FlowerColor = "Yellow", Photography = "Couple Photos", Dresses = "Hire", Amount = 200000.00 },
            new Models.Reservations { WeddingId = 4, BrideGroomNames = "Harry and Jinny", Venue = "Galle", Date = "2023.08.05", GuestsNo = 250, MusicType = "DJ", FlowerColor = "White", Photography = "Couple and Family Photos", Dresses = "Hire", Amount = 350000.00 },
            new Models.Reservations { WeddingId = 5, BrideGroomNames = "Charles and Diana", Venue = "Kurunegala", Date = "2024.09.10", GuestsNo = 500, MusicType = "Live Band", FlowerColor = "Red", Photography = "Couple Videos with Photos", Dresses = "Buy", Amount = 500000.00 },
        };
    }
}
