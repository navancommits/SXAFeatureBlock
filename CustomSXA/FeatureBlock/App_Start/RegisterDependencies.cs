using CustomSXA.Feature.CustomRenderings.Controllers;
using CustomSXA.Feature.CustomRenderings.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.XA.Feature.Media.Repositories;

namespace CustomSXA.Feature.CustomRenderings.App_Start
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IGeneralListRepository, GeneralListRepository>();
            serviceCollection.AddTransient<GeneralListController>();

            serviceCollection.AddTransient<IImageRepository, BannerRepository>();
            serviceCollection.AddTransient<BannerController>();
        }
    }
}

