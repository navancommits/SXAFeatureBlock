using CustomSXA.Feature.CustomRenderings.Repositories;
using Sitecore.XA.Foundation.RenderingVariants.Controllers.Base;

namespace CustomSXA.Feature.CustomRenderings.Controllers
{
    public class GeneralListController : PaginableController
    {
        protected IGeneralListRepository GeneralListRepository { get; }

        public GeneralListController(IGeneralListRepository repository) => this.GeneralListRepository = repository;

        protected override object GetModel() => (object)this.GeneralListRepository.GetModel(this.PaginationConfiguration);
    }
}

