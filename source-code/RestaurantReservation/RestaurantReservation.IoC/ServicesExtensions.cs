using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using RestaurantReservation.Core.RestaurantContext;
using RestaurantReservation.DomainServices.Common;
using RestaurantReservation.DomainServices.RestaurantContext;
using RestaurantReservation.Infrastructure.RestaurantContext;

namespace RestaurantReservation.IoC
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped(typeof(IRepository<Restaurant>), typeof(RestaurantRepository));
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();

            return services;
        }
    }
}
