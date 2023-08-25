using Sitecore.Data.Items;
using Sitecore.XA.Foundation.IoC;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Lists.Pagination;
using Sitecore.XA.Foundation.RenderingVariants.Models;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace CustomSXA.Feature.CustomRenderings.Repositories
{
    public class GeneralListRepository :
      ListRepository,
      IGeneralListRepository,
      IModelRepository,
      IControllerRepository,
      IAbstractRepository<IRenderingModelBase>
    {
        public override IRenderingModelBase GetModel()
        {
            VariantListsRenderingModel variantListsRenderingModel = new VariantListsRenderingModel();
            this.FillBaseProperties((object)variantListsRenderingModel);
            variantListsRenderingModel.Items = this.GetItems();
            return (IRenderingModelBase)variantListsRenderingModel;
        }

        public IRenderingModelBase GetModel(IListPagination paginationConfiguration)
        {
            VariantListsRenderingModel variantListsRenderingModel = new VariantListsRenderingModel();
            this.FillBaseProperties((object)variantListsRenderingModel);
            variantListsRenderingModel.Items = (IEnumerable<Item>)this.GetItems().Skip<Item>(paginationConfiguration.Skip).Take<Item>(paginationConfiguration.PageSize).ToList<Item>();
            return (IRenderingModelBase)variantListsRenderingModel;
        }
    }
}
