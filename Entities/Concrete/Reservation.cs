using System;
using WFAHotelRezervasyon.Entities.Abstract;

namespace WFAHotelRezervasyon.Entities.Concrete
{
    public class Reservation : BaseEntities
    {
        
        
        public Hotel Hotel { get; set; }
        
        private DateTime _reservationDate = DateTime.Now;

        public DateTime ReservationTime
        {
            get { return _reservationDate; }
            set { _reservationDate = value; }
        }

        public Customer Customer { get; set; }
    }
}
