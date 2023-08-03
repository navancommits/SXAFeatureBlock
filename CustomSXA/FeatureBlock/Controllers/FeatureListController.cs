using CustomSXA.Feature.CustomRenderings.Repositories;
using Sitecore.XA.Foundation.RenderingVariants.Controllers.Base;

namespace CustomSXA.Feature.CustomRenderings.Controllers
{
    public class FeatureListController : PaginableController
    {
        protected IFeatureListRepository FeatureListRepository { get; }

        public FeatureListController(IFeatureListRepository repository) => this.FeatureListRepository = repository;

        protected override object GetModel() => (object)this.FeatureListRepository.GetModel(this.PaginationConfiguration);
    }
}

