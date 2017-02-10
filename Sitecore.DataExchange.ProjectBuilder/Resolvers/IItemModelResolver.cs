namespace Sitecore.DataExchange.ProjectBuilder.Resolvers
{
    using Services.Core.Model;

    public interface IItemModelResolver
    {
        ItemModel Resolve();
    }
}