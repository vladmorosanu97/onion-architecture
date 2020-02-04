using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;

namespace RestaurantReservation.Core.RestaurantContext
{
    public class TableMap: ClassMap<Table>
    {
        public TableMap()
        {
            Table("Table");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Seats);
            HasOne(x => x.Shape);
            References(x => x.Section, "SectionId").Cascade.None();
        }
    }
}
