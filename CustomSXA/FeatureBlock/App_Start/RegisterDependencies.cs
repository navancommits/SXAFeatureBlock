﻿using CustomSXA.Feature.CustomRenderings.Controllers;
using CustomSXA.Feature.CustomRenderings.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace CustomSXA.Feature.CustomRenderings.App_Start
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IFeatureListRepository, FeatureListRepository>();
            serviceCollection.AddTransient<FeatureListController>();
        }
    }
}
