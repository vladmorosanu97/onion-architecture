using System;
using System.Collections.Generic;
using System.Text;
using RestaurantReservation.Core.Common;

namespace RestaurantReservation.Core.SharedKernel
{
    public class UserRole : Entity
    {
        public static UserRole Waiter = new UserRole(1, "Waiter", "The waiter manages the reservations", null);
        public static UserRole Customer = new UserRole(2, "Customer", "The customer creates reservations", null);

        public virtual string Name { get; }
        public virtual string Description { get; }
        public virtual IList<User> Users { get; set; }

        protected UserRole()
        {

        }

        public UserRole(int id, string name, string description, IList<User> users)
        {
            Id = id;
            Name = name;
            Description = description;
            Users = users;
        }
    }
}
