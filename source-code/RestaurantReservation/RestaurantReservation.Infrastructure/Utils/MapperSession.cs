using System.Linq;
using NHibernate;
using RestaurantReservation.Core.Common;

namespace RestaurantReservation.Infrastructure.Utils
{
    public class MapperSession<T>: IMapperSession<T> where T: AggregateRoot
    {
        private readonly ISession _session;
        private ITransaction _transaction;

        public MapperSession(ISession session)
        {
            _session = session;
        }
        public void BeginTransaction()
        {
            _transaction = _session.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        public void CloseTransaction()
        {
            if (_transaction != null)
            {
                // TODO: is necessary?
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public void Save(T entity)
        {
            _session.SaveOrUpdate(entity);
        }

        public void Delete(T entity)
        {
            _session.Delete(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _session.Query<T>();
        }

        public T GetById(int id)
        {
            return _session.Query<T>().SingleOrDefault(x => x.Id == id);
        }
    }
}
