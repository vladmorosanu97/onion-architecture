using RestaurantReservation.Core.Common;

namespace RestaurantReservation.Core.RestaurantContext
{
    public class Table: Entity
    {
        public virtual string Name { get; set; }
        public virtual int Seats { get; set; }
        public virtual Shape Shape { get; }
        public virtual Section Section { get; protected set; }

        protected Table()
        {

        }

        public Table(Section section, Shape shape, string name, int seats)
        {
            Section = section;
            Shape = shape;
            Name = name;
            Seats = seats;
        }
    }
}
