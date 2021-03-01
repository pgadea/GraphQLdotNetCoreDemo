using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenu subMenuService)
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
            Field<ListGraphType<SubMenuType>>("subMenus", resolve: context => { return subMenuService.GetSubMenus(context.Source.Id); });
        }
    }
}
