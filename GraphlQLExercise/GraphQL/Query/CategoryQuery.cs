using GraphlQLExercise.GraphQL.Type;
using GraphlQLExercise.Interfaces;
using GraphQL;
using GraphQL.Types;

namespace GraphlQLExercise.GraphQL.Query
{
    public class CategoryQuery : ObjectGraphType
    {
        public CategoryQuery(ICategoryRepository repo) => Field<ListGraphType<CategoryType>>("Categories").Resolve(context => repo.GetCategories());
        
    }
}
