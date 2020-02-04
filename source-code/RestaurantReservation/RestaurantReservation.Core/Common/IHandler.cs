﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantReservation.Core.Common
{
    public interface IHandler<T>
        where T : IDomainEvent
    {
        void Handle(T domainEvent);
    }
}
