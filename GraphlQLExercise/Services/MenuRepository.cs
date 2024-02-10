using GraphlQLExercise.Data;
using GraphlQLExercise.Interfaces;
using GraphlQLExercise.Models;

namespace GraphlQLExercise.Services
{
    public class MenuRepository : IMenuRepository
    {
        private readonly GraphQLDBContext _ctx;

        public MenuRepository(GraphQLDBContext ctx) => _ctx = ctx;


        public List<Menu> GetAllMenus() => _ctx.Menus.ToList();
        public Menu GetMenuById(int id) => _ctx.Menus.Find(id);



        public Menu AddMenu(Menu menu)
        {
            _ctx.Menus.Add(menu);
            _ctx.SaveChanges();

            return menu;
        }


        public void DeleteMenu(int id)
        {
            var menu = _ctx.Menus.Find(id);
            _ctx.Menus.Remove(menu);

            _ctx.SaveChanges();
        }


        public Menu UpdateMenu(Menu menu, int id)
        {
            var updatingMenu = _ctx.Menus.Find(id);

            updatingMenu.Description = menu.Description;
            updatingMenu.Price = menu.Price;
            updatingMenu.Name = menu.Name;

            _ctx.SaveChanges();

            return updatingMenu;
        }
    }
}
