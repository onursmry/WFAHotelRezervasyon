﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAHotelRezervasyon.Entities.Concrete;

namespace WFAHotelRezervasyon.Repositories.Interfaces
{
    public interface IListReservation
    {
        List<Reservation> ListReservation();
    }
}
