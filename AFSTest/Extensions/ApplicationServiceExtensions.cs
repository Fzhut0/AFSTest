using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSTest.Repositories;
using AFSTest.Repositories.Interfaces;
using AFSTest.Services;
using AFSTest.Services.Interfaces;

namespace AFSTest.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddHttpClient<ITranslationService, TranslationService>();
            services.AddScoped<ITranslationRepository, TranslationRepository>();

            return services;
        }
    }
}