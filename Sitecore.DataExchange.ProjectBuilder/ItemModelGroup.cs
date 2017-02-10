namespace Sitecore.DataExchange.ProjectBuilder
{
    using System.Collections.Generic;
    using Resolvers;

    public class ItemModelGroup : IItemModelGroup
    {
        public string GroupName { get; set; }
        public IList<IProjectModel> ProjectModels { get; set; }
        
        public IItemModelResolver ItemModelResolver { get; set; }

        public ItemModelGroup()
        {
            
        }

        public ItemModelGroup(IItemModelResolver itemModelResolver)
        {
            this.ItemModelResolver = itemModelResolver;
            //TODO: resolve by list of nodes
        }

    }
}