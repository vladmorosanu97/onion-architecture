using System.Collections.Generic;
using RestaurantReservation.Core.Common;

namespace RestaurantReservation.Core.SharedKernel
{
    public class User: AggregateRoot
    {
        public virtual string FirstName { get; protected set; }
        public virtual string LastName { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string PasswordHash { get; protected set; }
        public virtual IList<UserRole> UserRoles { get; set; }

        protected User()
        {

        }

        // TODO: refactor this
        public User(string firstName, string lastName, string email, string passwordHash, IList<UserRole> userRoles)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PasswordHash = passwordHash;
            UserRoles = userRoles;
        }
    }
}
