using System;
using System.Collections.Generic;
using System.Text;
using RestaurantReservation.Core.Common;

namespace RestaurantReservation.Core.RestaurantContext
{
    public class Section: Entity
    {
        public virtual string Name { get; protected set; }
        public virtual Restaurant Restaurant { get; protected set; }
        public virtual IList<Table> Tables { get; set; }

        protected Section()
        {

        }

        public Section(Restaurant restaurant, string name)
        {
            Restaurant = restaurant;
            Name = name;
            Tables = new List<Table>();
        }
    }
}
