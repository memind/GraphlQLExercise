using GraphlQLExercise.GraphQL.Type;
using GraphlQLExercise.Interfaces;
using GraphlQLExercise.Models;
using GraphQL;
using GraphQL.Types;

namespace GraphlQLExercise.GraphQL.Mutation
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservationRepository repo)
        {
            Field<ReservationType>("CreateReservation").Arguments(new QueryArguments(new QueryArgument<ReservationInputType> { Name = "reservation" })).Resolve(ctx => repo.AddReservation(ctx.GetArgument<Reservation>("reservation")));
        }
    }
}
