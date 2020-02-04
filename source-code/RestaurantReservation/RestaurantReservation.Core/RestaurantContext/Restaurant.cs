using System;
using System.Collections.Generic;
using System.Text;
using RestaurantReservation.Core.Common;

namespace RestaurantReservation.Core.RestaurantContext
{
    public class Restaurant: AggregateRoot
    {
        public virtual string Name { get; protected set; }
        public virtual string Address { get; protected set; }
        public virtual IList<Section> Sections { get; set; }

        protected Restaurant()
        {

        }

        public Restaurant(string name, string address)
        {
            Name = name;
            Address = address;
            Sections = new List<Section>();
        }
    }
}
