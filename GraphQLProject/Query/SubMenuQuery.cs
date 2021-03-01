using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Type;

namespace GraphQLProject.Query
{
    public class SubMenuQuery : ObjectGraphType
    {
        public SubMenuQuery(ISubMenu subMenuService)
        {
            Field<ListGraphType<SubMenuType>>("subMenus", resolve: context => { return subMenuService.GetSubMenus(); });
            Field<SubMenuType>("subMenuById", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
              resolve: context =>
              {
                  return subMenuService.GetSubMenus(context.GetArgument<int>("id"));
              });
        }
    }
}
