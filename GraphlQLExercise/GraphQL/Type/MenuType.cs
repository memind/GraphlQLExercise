using GraphlQLExercise.Models;
using GraphQL.Types;

namespace GraphlQLExercise.GraphQL.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Description);
            Field(m => m.Price);
            Field(m => m.CategoryId);
            Field(m => m.ImageUrl);
        }
    }
}
