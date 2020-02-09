using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantReservation.Core.Common;
using RestaurantReservation.Core.SharedKernel;

namespace RestaurantReservation.Infrastructure.Utils
{
    public interface IMapperSession<T> where T: AggregateRoot
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        void CloseTransaction();
        void Save(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
        T GetById(int id);
    }
}
