using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using RestaurantReservation.Core.Common;
using RestaurantReservation.Core.SharedKernel;

namespace RestaurantReservation.Infrastructure.Utils
{
    public class NHibernateMapperSession<T>: IMapperSession<T> where T: AggregateRoot
    {
        private readonly ISession _session;
        private ITransaction _transaction;

        public NHibernateMapperSession(ISession session)
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

        public IQueryable<T> GetAll()
        {
            return _session.Query<T>();
        }
    }
}
