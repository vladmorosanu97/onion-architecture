using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantReservation.API.ViewModels;
using RestaurantReservation.Core.RestaurantContext;

namespace RestaurantReservation.API.Mappers
{
    public static class RestaurantMapper
    {
        public static Restaurant GetDataItem(this RestaurantDto dto)
        {
            return new Restaurant(dto.Name, dto.Address);
        }
    }
}
