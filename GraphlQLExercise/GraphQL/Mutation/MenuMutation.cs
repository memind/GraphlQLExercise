using GraphlQLExercise.GraphQL.Type;
using GraphlQLExercise.Interfaces;
using GraphlQLExercise.Models;
using GraphQL;
using GraphQL.Types;

namespace GraphlQLExercise.GraphQL.Mutation
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenuRepository repo)
        {
            Field<MenuType>("CreateMenu").Arguments(new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" })).Resolve(ctx => repo.AddMenu(ctx.GetArgument<Menu>("menu")));

            Field<MenuType>("UpdateMenu").Arguments(new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }, new QueryArgument<IntGraphType> { Name = "menuId" })).Resolve(ctx =>
            {
                var menu = ctx.GetArgument<Menu>("menu");
                var menuId = ctx.GetArgument<int>("menuId");

                return repo.UpdateMenu(menu, menuId);
            });

            Field<StringGraphType>("DeleteMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" })).Resolve(ctx =>
            {
                var menuId = ctx.GetArgument<int>("menuId");
                repo.DeleteMenu(menuId);

                return $"Deleted Menu: {menuId}";
            });
        }
    }

}