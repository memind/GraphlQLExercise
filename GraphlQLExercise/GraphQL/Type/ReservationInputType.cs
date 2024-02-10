using GraphQL.Types;

namespace GraphlQLExercise.GraphQL.Type
{
    public class ReservationInputType : InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>("id");
            Field<IntGraphType>("partySize");
            Field<StringGraphType>("customerName");
            Field<StringGraphType>("email");
            Field<StringGraphType>("phoneNumber");
            Field<DateGraphType>("reservationDate");
        }
    }
}
