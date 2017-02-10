namespace Sitecore.DataExchange.ProjectBuilder
{
    using System.Collections.Generic;
    using System.Linq;

    public interface IProjectTemplates
    {
        IList<IProjectTemplate> ProjectTemplates { get; set; }
    }
}