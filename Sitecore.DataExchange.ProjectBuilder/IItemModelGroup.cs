namespace Sitecore.DataExchange.ProjectBuilder
{
    using System.Collections.Generic;
    using Services.Core.Model;

    public interface IItemModelGroup
    {
        string GroupName { get; set; }
        IList<IProjectModel> ProjectModels { get; set; }
    }
}