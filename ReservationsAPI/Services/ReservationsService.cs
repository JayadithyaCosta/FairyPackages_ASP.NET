using FairyWeddingsAPI.Data;
using FairyWeddingsAPI.Models;

namespace FairyWeddingsAPI.Services
{
    public class ReservationsService : IReservationsService
    {
        public List<Models.Reservations> GetReservations()
        {
            return ReservationsMockDataService.Reservations;
        }

        public Models.Reservations? GetReservations(int id)
        {
            return ReservationsMockDataService.Reservations.FirstOrDefault(x => x.WeddingId == id);
        }

        public Models.Reservations? AddReservations(Models.Reservations? reservations)
        {
            ReservationsMockDataService.Reservations.Add(reservations);
            return reservations;
        }

        public Models.Reservations? UpdateReservations(Models.Reservations? reservations)
        {
            Models.Reservations selectedReservations = ReservationsMockDataService.Reservations.FirstOrDefault(x => x.WeddingId == reservations.WeddingId);
            if (selectedReservations != null)
            {
                selectedReservations.BrideGroomNames = reservations.BrideGroomNames;
                selectedReservations.Venue = reservations.Venue;
                selectedReservations.Date = reservations.Date;
                selectedReservations.GuestsNo = reservations.GuestsNo;
                selectedReservations.MusicType = reservations.MusicType;
                selectedReservations.FlowerColor = reservations.FlowerColor;
                selectedReservations.Photography = reservations.Photography;
                selectedReservations.Dresses = reservations.Dresses;
                selectedReservations.Amount = reservations.Amount;
            }

            return selectedReservations;
        }

        public bool? DeleteReservations(int id)
        {
            Models.Reservations selectedReservations = ReservationsMockDataService.Reservations.FirstOrDefault(x => x.WeddingId == id);
            if (selectedReservations != null)
            {
                ReservationsMockDataService.Reservations.Remove(selectedReservations);
                return true;
            }
            return false;
        }
    }
}
