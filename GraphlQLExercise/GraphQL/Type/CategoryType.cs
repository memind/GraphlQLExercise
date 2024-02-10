using GraphlQLExercise.Interfaces;
using GraphlQLExercise.Models;
using GraphQL.Types;

namespace GraphlQLExercise.GraphQL.Type
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType(IMenuRepository menuRepo)
        {
            Field(c => c.Id);
            Field(c => c.Name);
            Field(c => c.ImageUrl);

            Field<ListGraphType<MenuType>>("Menus").Resolve(context => menuRepo.GetAllMenus());
        }
    }
}
