using GraphlQLExercise.GraphQL.Type;
using GraphlQLExercise.Interfaces;
using GraphlQLExercise.Models;
using GraphQL;
using GraphQL.Types;

namespace GraphlQLExercise.GraphQL.Mutation
{
    public class CategoryMutation : ObjectGraphType
    {
        public CategoryMutation(ICategoryRepository repo)
        {
            Field<CategoryType>("CreateCategory").Arguments(new QueryArguments(new QueryArgument<CategoryInputType> { Name = "category" })).Resolve(ctx => repo.AddCategory(ctx.GetArgument<Category>("category")));

            Field<CategoryType>("UpdateCategory").Arguments(new QueryArguments(new QueryArgument<CategoryInputType> { Name = "category" }, new QueryArgument<IntGraphType> { Name = "categoryId" })).Resolve(ctx =>
            {
                var category = ctx.GetArgument<Category>("category");
                var categoryId = ctx.GetArgument<int>("categoryId");

                return repo.UpdateCategory(category, categoryId);
            });

            Field<StringGraphType>("DeleteCategory").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "categoryId" })).Resolve(ctx =>
            {
                var categoryId = ctx.GetArgument<int>("categoryId");
                repo.DeleteCategory(categoryId);

                return $"Deleted Category: {categoryId}";
            });
        }
    }
}
