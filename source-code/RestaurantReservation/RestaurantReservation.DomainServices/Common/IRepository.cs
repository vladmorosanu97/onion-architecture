using System.Linq;
using RestaurantReservation.Core.Common;

namespace RestaurantReservation.DomainServices.Common
{
    public interface IRepository<T> where T : AggregateRoot
    {
        IQueryable<T> GetAll();

        T GetById(int id);
        void Save(T aggregateRoot);
    }
}
