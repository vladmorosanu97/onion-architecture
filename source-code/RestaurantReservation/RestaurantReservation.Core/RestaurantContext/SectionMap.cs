using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;

namespace RestaurantReservation.Core.RestaurantContext
{
    public class SectionMap: ClassMap<Section>
    {
        public SectionMap()
        {
            Table("Section");
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Tables).KeyColumn("SectionId").Inverse().Cascade.All();
            References(x => x.Restaurant, "RestaurantId").Cascade.None();
        }
    }
}
