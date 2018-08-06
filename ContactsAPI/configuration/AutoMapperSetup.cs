using AutoMapper;
using ContactsAPI.Application;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ContactsAPI.configuration
{
    public static class AutoMapperSetup
    {
        public static void ConfigureAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper();

            AutoMapperConfig.RegisterMappings();
        }
    }
}
