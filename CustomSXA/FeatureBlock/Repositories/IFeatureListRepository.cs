using Sitecore.XA.Foundation.IoC;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Lists.Pagination;

namespace CustomSXA.Feature.CustomRenderings.Repositories
{
    public interface IFeatureListRepository :
    IModelRepository,
    IControllerRepository,
    IAbstractRepository<IRenderingModelBase>
    {
        IRenderingModelBase GetModel(IListPagination paginationConfiguration);
    }
}
