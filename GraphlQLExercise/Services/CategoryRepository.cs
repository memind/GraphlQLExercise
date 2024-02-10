using GraphlQLExercise.Data;
using GraphlQLExercise.Interfaces;
using GraphlQLExercise.Models;

namespace GraphlQLExercise.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly GraphQLDBContext _ctx;

        public CategoryRepository(GraphQLDBContext ctx) => _ctx = ctx;
        


        public Category AddCategory(Category category)
        {
            _ctx.Categories.Add(category);
            return category;
        }


        public void DeleteCategory(int id)
        {
            var deletingCategory = _ctx.Categories.FirstOrDefault(c => c.Id == id);

            _ctx.Categories.Remove(deletingCategory);
            _ctx.SaveChanges();
        }


        public List<Category> GetCategories() => _ctx.Categories.ToList();


        public Category UpdateCategory(Category category, int id)
        {
            var updatingCategory = _ctx.Categories.FirstOrDefault(c => c.Id == id);

            updatingCategory.Name = category.Name;
            updatingCategory.ImageUrl = category.ImageUrl;
            updatingCategory.Menus = category.Menus;

            _ctx.SaveChanges();

            return updatingCategory;
        }
    }
}
