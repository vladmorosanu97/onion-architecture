using System;
using System.Collections.Generic;
using System.Text;
using RestaurantReservation.Core.Common;
using RestaurantReservation.Core.RestaurantContext;
using RestaurantReservation.DomainServices.Common;

namespace RestaurantReservation.DomainServices.RestaurantContext
{
    public interface IRestaurantRepository: IRepository<Restaurant>
    {
    }
}
