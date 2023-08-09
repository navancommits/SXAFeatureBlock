using Sitecore.Data.Fields;
using Sitecore.XA.Feature.Media.Models;
using Sitecore.XA.Feature.Media.Repositories;
using Sitecore.XA.Foundation.IoC;
using Sitecore.XA.Foundation.Multisite.LinkManagers;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Models;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;
using System;

namespace CustomSXA.Feature.CustomRenderings.Repositories
{
    public class BannerRepository :
    VariantsRepository,
    IImageRepository,
    IModelRepository,
    IControllerRepository,
    IAbstractRepository<IRenderingModelBase>
    {
        protected virtual LinkItem GetLinkItem() => this.Rendering.DataSourceItem != null ? new LinkItem((LinkField)this.Rendering.DataSourceItem.Fields[Sitecore.XA.Feature.Media.Templates.Image.Fields.TargetUrl]) : (LinkItem)null;

        public override IRenderingModelBase GetModel()
        {
            ImageRenderingModel m = new ImageRenderingModel();
            this.FillBaseProperties((object)m);
            m.Href = ((dataSource, linkFieldName) =>
            {
                string targetUrl = new LinkItem((LinkField)this.Rendering.DataSourceItem.Fields[Sitecore.XA.Feature.Media.Templates.Image.Fields.TargetUrl]).TargetUrl;
                return string.IsNullOrWhiteSpace(targetUrl) ? "#" : targetUrl;
            });
            return (IRenderingModelBase)m;
        }
    }
}
