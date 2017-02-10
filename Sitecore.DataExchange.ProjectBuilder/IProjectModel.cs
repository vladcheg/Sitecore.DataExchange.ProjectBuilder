namespace Sitecore.DataExchange.ProjectBuilder
{
    using System.Collections.Generic;
    using Services.Core.Model;

    public interface IProjectModel
    {
        ItemModel ItemModel { get; set; }
        IList<IProjectModel> ProjectModels { get; set; }
    }
}