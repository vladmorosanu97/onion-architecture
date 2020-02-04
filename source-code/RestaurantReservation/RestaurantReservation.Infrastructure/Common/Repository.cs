using System.Linq;
using NHibernate;
using RestaurantReservation.Core.Common;
using RestaurantReservation.DomainServices.Common;
using RestaurantReservation.Infrastructure.Utils;

namespace RestaurantReservation.Infrastructure.Common
{
    public abstract class Repository<T>:IRepository<T> where  T: AggregateRoot
    {
        private IMapperSession<T> _mapperSession;

        protected Repository(IMapperSession<T> mapperSession)
        {
            this._mapperSession = mapperSession;
        }

        public IQueryable<T> GetAll()
        {
            _mapperSession.BeginTransaction();
            return _mapperSession.GetAll();
        }

        public T GetById(long id)
        {
            // _mapperSession.BeginTransaction();
            // _mapperSession.GetAll();
            // return // using (ISession session = SessionFactory.OpenSession())
            // // {
            // //     return session.Get<T>(id);
            // // }
            throw new System.NotImplementedException();
        }

        public void Save(T aggregateRoot)
        {
            using (ISession session = SessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.SaveOrUpdate(aggregateRoot);
                transaction.Commit();
            }
        }
    }
}
