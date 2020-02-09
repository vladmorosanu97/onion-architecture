using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;

namespace RestaurantReservation.Core.Common
{
   public class ShapeMap: ClassMap<Shape>
    {
        public ShapeMap()
        {
            Table("Shape");
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}
