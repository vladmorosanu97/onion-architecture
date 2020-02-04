using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;

namespace RestaurantReservation.Core.SharedKernel
{
    public class UserRoleMap: ClassMap<UserRole>
    {
        public UserRoleMap()
        {
            Id(x => x.Id);
            HasManyToMany(x => x.Users)
                .Cascade.All()
                .Inverse()
                .Table("UserUserRole");
        }
    }
}
