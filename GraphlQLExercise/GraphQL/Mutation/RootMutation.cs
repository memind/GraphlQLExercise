using GraphlQLExercise.GraphQL.Query;
using GraphQL.Types;

namespace GraphlQLExercise.GraphQL.Mutation
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Field<MenuMutation>("menuMutation").Resolve(context => new { });
            Field<ReservationMutation>("reservationMutation").Resolve(context => new { });
            Field<CategoryMutation>("categoryMutation").Resolve(context => new { });
        }
    }
}
