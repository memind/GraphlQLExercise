using GraphlQLExercise.Models;

namespace GraphlQLExercise.Interfaces
{
    public interface IReservationRepository
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
    }
}
