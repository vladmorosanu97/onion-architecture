using Microsoft.Extensions.DependencyInjection;
using RestaurantReservation.Infrastructure.Utils;

namespace RestaurantReservation.IoC
{
    public static class NHibernateExtensions
    {
        public static IServiceCollection AddNHibernate(this IServiceCollection services, string connectionString)
        {
            var sessionFactory = SessionFactory.BuildSessionFactory(connectionString);

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());
            services.AddScoped(typeof(IMapperSession<>), typeof(MapperSession<>));

            return services;
        }
    }
}
