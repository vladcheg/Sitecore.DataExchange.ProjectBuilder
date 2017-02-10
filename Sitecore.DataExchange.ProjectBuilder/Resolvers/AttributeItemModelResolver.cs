namespace Sitecore.DataExchange.ProjectBuilder.Resolvers
{
    using System.Xml;
    using Services.Core.Model;
    /// <summary>
    /// Class AttributeItemModelResolver resolves item model by attributes name and value.
    /// </summary>
    public class AttributeItemModelResolver : IItemModelResolver
    {
        /// <summary>
        /// Gets or sets the item model XML node.
        /// </summary>
        /// <value>The item model XML node.</value>
        protected XmlNode ItemModelXmlNode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeItemModelResolver"/> class.
        /// </summary>
        /// <param name="xmlNode">The XML node.</param>
        public AttributeItemModelResolver(XmlNode xmlNode)
        {
            this.ItemModelXmlNode = xmlNode;
        }

        /// <summary>
        /// Resolves item model.
        /// </summary>
        /// <returns>ItemModel.</returns>
        public virtual ItemModel Resolve()
        {
            var attributes = this.ItemModelXmlNode.Attributes;
            if (attributes == null || attributes.Count < 1)
            {
                return null;
            }

            var itemModel = new ItemModel();

            foreach (XmlAttribute attribute in attributes)
            {
                itemModel[attribute.Name] = attribute.Value;
            }

            return itemModel;
        }
    }
}