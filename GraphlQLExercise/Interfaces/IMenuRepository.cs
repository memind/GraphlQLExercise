using GraphlQLExercise.Models;

namespace GraphlQLExercise.Interfaces
{
    public interface IMenuRepository
    {
        List<Menu> GetAllMenus();
        Menu GetMenuById(int id);
        Menu AddMenu(Menu menu);
        Menu UpdateMenu(Menu menu, int id);
        void DeleteMenu(int id);
    }
}
