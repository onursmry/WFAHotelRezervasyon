using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAHotelRezervasyon.Classes;
using WFAHotelRezervasyon.Entities.Concrete;
using WFAHotelRezervasyon.Repositories.Abstract;
using WFAHotelRezervasyon.Repositories.Interfaces;

namespace WFAHotelRezervasyon.Repositories.Concrete
{
    public class ReservationRepository : BaseReservationRepository, IListHotel, IListReservation
    {
        public override void CreateReservation(int id, Customer customer, Hotel hotel)
        {
            Reservation reservation = new Reservation();
            reservation.Id = id;
            reservation.Customer = customer;
            reservation.Hotel = hotel;

            //reservation.Customer.Name= customer.Name;
            //reservation.Customer.Surname = customer.Surname;
            //reservation.Hotel.HotelName = hotel.HotelName;
            //reservation.Hotel.HotelLocation = hotel.HotelLocation;
            //reservation.Hotel.AccommodationType = hotel.AccommodationType;
            //reservation.Hotel.HotelPrice = hotel.HotelPrice;
            //reservation.Hotel.CurrencyUnit = hotel.CurrencyUnit;
        }

        public override void DeleteReservation(int id)
        {
            foreach (var variable in SeedData.Reservations)
            {
                if (variable.Id == id)
                {
                    SeedData.Reservations.Remove(variable);
                    break;
                }
            }
            {
                throw new NotImplementedException();
            }
        }

        public void ListHotel(ComboBox comboBox)
        {
            SeedData.Hotels.ForEach(x => comboBox.Items.Add(x.HotelName));
        }

        public List<Reservation> ListReservation()
        {
            return SeedData.Reservations.ToList();
        }
    }
}
