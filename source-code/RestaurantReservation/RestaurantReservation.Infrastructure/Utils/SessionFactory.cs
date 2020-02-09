using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using RestaurantReservation.Core.Common;
using RestaurantReservation.Core.RestaurantContext;
using RestaurantReservation.Infrastructure.RestaurantContext;

namespace RestaurantReservation.Infrastructure.Utils
{
    public static class SessionFactory
    {
        public static ISessionFactory BuildSessionFactory
            (string connectionString, bool create = false, bool update = false)
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Entity>())
                .CurrentSessionContext("call")
                .ExposeConfiguration(cfg => BuildSchema(cfg, create, update))
                .BuildSessionFactory();
        }

        private static void BuildSchema(Configuration config, bool create = false, bool update = false)
        {
            if (create)
            {
                new SchemaExport(config).Create(false, true);
            }
            else
            {
                new SchemaUpdate(config).Execute(false, update);
            }
        }


        // TODO: REMOVE THIS
        public class HiLoConvention : IIdConvention
        {
            public void Apply(IIdentityInstance instance)
            {
                instance.Column(instance.EntityType.Name + "ID");
                instance.GeneratedBy.HiLo("[dbo].[Ids]", "NextHigh", "9",
                    "EntityName = '" + instance.EntityType.Name + "'");
            }
        }
    }
}
