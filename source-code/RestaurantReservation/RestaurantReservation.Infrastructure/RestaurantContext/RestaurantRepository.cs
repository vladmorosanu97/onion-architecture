using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using NHibernate.Mapping;
using RestaurantReservation.Core.RestaurantContext;
using RestaurantReservation.DomainServices.RestaurantContext;
using RestaurantReservation.Infrastructure.Common;
using RestaurantReservation.Infrastructure.Utils;

namespace RestaurantReservation.Infrastructure.RestaurantContext
{
    // Used for particular queries only for RestaurantRepository
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        private readonly IMapperSession<Restaurant> _mapperSession;

        public RestaurantRepository(IMapperSession<Restaurant> mapperSession) : base(mapperSession)
        {
            _mapperSession = mapperSession;
        }
    }
}
