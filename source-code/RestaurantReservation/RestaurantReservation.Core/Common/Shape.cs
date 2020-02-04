using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantReservation.Core.Common
{
    public class Shape: Entity
    {
        public static readonly Shape Round = new Shape(1, "Round table");
        public static readonly Shape Square = new Shape(2, "Square table");
        public virtual string Name { get; }

        private Shape(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
