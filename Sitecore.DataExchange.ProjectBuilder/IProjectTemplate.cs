namespace Sitecore.DataExchange.ProjectBuilder
{
    using System.Collections.Generic;

    public interface IProjectTemplate
    {
        bool Default { get; set; }
        string ProjectName { get; set; }

        IList<IItemModelGroup> ItemModelGroups { get; set; }
    }
}