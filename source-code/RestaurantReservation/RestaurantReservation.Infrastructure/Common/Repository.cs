using System.Configuration;
using System.Linq;
using Microsoft.Extensions.Configuration;
using NHibernate;
using RestaurantReservation.Core.Common;
using RestaurantReservation.Core.RestaurantContext;
using RestaurantReservation.DomainServices.Common;
using RestaurantReservation.Infrastructure.Utils;

namespace RestaurantReservation.Infrastructure.Common
{
    public abstract class Repository<T>: IRepository<T> where  T: AggregateRoot
    {
        private readonly IMapperSession<T> _mapperSession;

        protected Repository(IMapperSession<T> mapperSession)
        {
            _mapperSession = mapperSession;
        }

        public IQueryable<T> GetAll()
        {
            return _mapperSession.GetAll();
        }

        public T GetById(int id)
        {
            return _mapperSession.GetById(id);
        }

        public void Save(T aggregateRoot)
        {
            _mapperSession.Save(aggregateRoot);
        }
    }
}
