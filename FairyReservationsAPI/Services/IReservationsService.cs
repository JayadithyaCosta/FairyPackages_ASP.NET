namespace FairyWeddings.Reservations.Services
{
    public interface IReservationsService
    {
        List<Models.Reservations> GetReservations();
        Models.Reservations? GetReservations(int id);
        Models.Reservations? AddReservations(Models.Reservations reservations);
        Models.Reservations? UpdateReservations(Models.Reservations reservations);
        bool? DeleteReservations(int id);
    }
}
