namespace Sitecore.DataExchange.ProjectBuilder
{
    using System.Collections.Generic;

    public class ItemModelProjectTemplate : IProjectTemplate
    {
        public bool Default { get; set; }
        public string ProjectName { get; set; }
        public IList<IItemModelGroup> ItemModelGroups { get; set; }
    }
}