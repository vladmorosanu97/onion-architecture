using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;

namespace RestaurantReservation.Core.SharedKernel
{
    public class UserMap: ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Email);
            Map(x => x.PasswordHash);
            HasManyToMany(x => x.UserRoles)
                .Cascade.All()
                .Table("UserUserRole");
        }
    }
}
