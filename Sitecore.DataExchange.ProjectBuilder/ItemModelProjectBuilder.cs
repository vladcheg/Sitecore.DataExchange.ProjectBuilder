namespace Sitecore.DataExchange.ProjectBuilder
{
    using System;
    using Repositories;
    using Services.Core.Model;

    public class ItemModelProjectBuilder : IProjectBuilder
    {
        public IProjectTemplate ProjectTemplate { get; set; }

        public IItemModelRepository ItemModelRepository { get; set; }

        public ItemModelProjectBuilder(IItemModelRepository itemModelRepository)
        {
            this.ItemModelRepository = itemModelRepository;
        }

        public virtual void Build()
        {
            foreach (var itemModelGroup in ProjectTemplate.ItemModelGroups)
            {
                DataExchange.Context.Logger.Info($"Resolve items from group. (group: {itemModelGroup.GroupName})");
                foreach (var projectModel in itemModelGroup.ProjectModels)
                {
                    this.CreateItemModel(projectModel, Guid.Empty);
                }

                DataExchange.Context.Logger.Info($"Resolve items from group finished. (group: {itemModelGroup.GroupName})");
            }
        }

        protected virtual void CreateItemModel(IProjectModel projectModel, Guid parentId)
        {
            if (projectModel.ItemModel[ItemModel.ParentID] == null)
            {
                projectModel.ItemModel[ItemModel.ParentID] = parentId.ToString();
            }
            var guid = this.ItemModelRepository.Create(projectModel.ItemModel);
            projectModel.ItemModel[ItemModel.ItemID] = guid.ToString();
            foreach (var pModel in projectModel.ProjectModels)
            {
                this.CreateItemModel(pModel, guid);
            }
        }
    }
}