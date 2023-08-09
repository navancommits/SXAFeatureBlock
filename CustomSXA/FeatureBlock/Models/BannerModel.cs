using Sitecore.XA.Foundation.RenderingVariants.Models;
using System.Drawing;

namespace CustomSXA.Feature.CustomRenderings.Models
{
    public class BannerModel: VariantListsRenderingModel
    {
        public Image Image { get; set; }
        public string Title { get; set; }
        public string Blurb { get; set; }
        public string Url { get; set; }
    }
}