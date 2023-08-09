using Sitecore.XA.Feature.Media.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;
using System.Web.Mvc;

namespace CustomSXA.Feature.CustomRenderings.Controllers
{
    public class BannerController : StandardController
    {
        protected IImageRepository BannerRepository { get; }

        public BannerController(IImageRepository imageRepository) => this.BannerRepository = imageRepository;

        public ActionResult ReusableImageIndex() => (ActionResult)this.PartialView("Banner", this.GetModel());

        protected override object GetModel() => (object)this.BannerRepository.GetModel();
    }
}

