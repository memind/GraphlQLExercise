using GraphlQLExercise.Data;
using GraphlQLExercise.Interfaces;
using GraphlQLExercise.Models;

namespace GraphlQLExercise.Services
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly GraphQLDBContext _ctx;

        public ReservationRepository(GraphQLDBContext ctx) => _ctx = ctx;



        public Reservation AddReservation(Reservation reservation)
        {
            _ctx.Reservations.Add(reservation);
            return reservation;
        }


        public List<Reservation> GetReservations() => _ctx.Reservations.ToList();
    }
}
