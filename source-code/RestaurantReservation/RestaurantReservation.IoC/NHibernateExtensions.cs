using System;
using Microsoft.Extensions.DependencyInjection;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Mapping.ByCode;
using RestaurantReservation.Core.SharedKernel;
using RestaurantReservation.DomainServices.Common;
using RestaurantReservation.Infrastructure.Common;
using RestaurantReservation.Infrastructure.RestaurantContext;
using RestaurantReservation.Infrastructure.Utils;

namespace RestaurantReservation.IoC
{
    public static class NHibernateExtensions
    {
        public static IServiceCollection AddNHibernate(this IServiceCollection services, string connectionString)
        {
            var mapper = new ModelMapper();
            mapper.AddMappings(typeof(NHibernateExtensions).Assembly.ExportedTypes);
            HbmMapping domainMapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

            var configuration = new Configuration();
            configuration.DataBaseIntegration(c =>
            {
                c.Dialect<MsSql2012Dialect>();
                c.ConnectionString = connectionString;
                c.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                c.SchemaAction = SchemaAutoAction.Validate;
                c.LogFormattedSql = true;
                c.LogSqlInConsole = true;
            });
            configuration.AddMapping(domainMapping);

            var sessionFactory = configuration.BuildSessionFactory();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());
            services.AddScoped(typeof(IMapperSession<>), typeof(NHibernateMapperSession<>));
            services.AddScoped<IRepository<User>, Repository<User>>();
            // services.AddScoped(typeof(IRepository<User>), typeof(RestaurantRepository));
            return services;
        }
    }
}
