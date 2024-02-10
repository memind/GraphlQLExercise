using GraphlQLExercise.GraphQL.Mutation;
using GraphlQLExercise.GraphQL.Query;
using GraphQL.Types;

namespace GraphlQLExercise.GraphQL.Schemas
{
    public class RootSchema : Schema
    {
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
