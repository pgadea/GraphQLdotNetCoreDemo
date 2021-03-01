using GraphQLProject.Models;
using System.Collections.Generic;

namespace GraphQLProject.Interfaces
{
    public interface IMenu
    {
        List<Menu> GetMenus();
        Menu AddMenu(Menu menu);
    }
}
