using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;

namespace RestaurantReservation.Core.RestaurantContext
{
    public class RestaurantMap: ClassMap<Restaurant>
    {
        public RestaurantMap()
        {
            Table("Restaurant");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Address);
            HasMany(x => x.Sections).KeyColumn("RestaurantId").Cascade.All();
        }
    }
}
