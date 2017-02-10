namespace Sitecore.DataExchange.ProjectBuilder
{
    using System.Collections.Generic;
    using Services.Core.Model;

    public class ProjectModel : IProjectModel
    {
        public ItemModel ItemModel { get; set; }
        public IList<IProjectModel> ProjectModels { get; set; }
    }
}