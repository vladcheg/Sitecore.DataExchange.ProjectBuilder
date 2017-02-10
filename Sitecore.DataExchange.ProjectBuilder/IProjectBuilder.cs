namespace Sitecore.DataExchange.ProjectBuilder
{
    public interface IProjectBuilder
    {
        IProjectTemplate ProjectTemplate { get; set; }

        void Build();

    }
}