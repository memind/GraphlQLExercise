using GraphlQLExercise.GraphQL.Type;
using GraphlQLExercise.Interfaces;
using GraphQL;
using GraphQL.Types;

namespace GraphlQLExercise.GraphQL.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenuRepository menuRepo)
        {
            Field<ListGraphType<MenuType>>("Menus").Resolve(context => menuRepo.GetAllMenus());
            Field<MenuType>("Menu")
                .Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" }))
                .Resolve(context => 
                    menuRepo.GetMenuById(context.GetArgument<int>("menuId")));
        }
    }
}
