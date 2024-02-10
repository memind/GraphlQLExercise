using GraphlQLExercise.GraphQL.Type;
using GraphlQLExercise.Interfaces;
using GraphQL;
using GraphQL.Types;

namespace GraphlQLExercise.GraphQL.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservationRepository repo) => Field<ListGraphType<ReservationType>>("Reservations").Resolve(context => repo.GetReservations());
        
    }
}
