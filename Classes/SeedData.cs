using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAHotelRezervasyon.Entities.Concrete;
using WFAHotelRezervasyon.Enums;

namespace WFAHotelRezervasyon.Classes
{
    internal class SeedData
    {
        public static List<Customer> Customers = new List<Customer>
        {
            new Customer
            {
                Id = 1,
                Name = "Ali",
                Surname = "Kılıç"
            },
            new Customer
            {
                Id = 2,
                Name = "Ahmet",
                Surname = "Kılıç"
            },
            new Customer
            {
                Id = 3,
                Name = "Mehmet",
                Surname = "Kılıç"
            },
            new Customer
            {
                Id = 4,
                Name = "Hasan",
                Surname = "Kılıç"
            },
            new Customer
            {
                Id = 5,
                Name = "Veli",
                Surname = "Kılıç"
            }
        };

        public static List<Hotel> Hotels = new List<Hotel>
        {
            new Hotel
            {
                Id = 1,
                HotelName = "Hilton",
                HotelLocation = Locations.Antalya,
                CurrencyUnit = CurrencyUnits.Euro,
                HotelPrice = 150
            },
            new Hotel
            {
                Id = 2,
                HotelName = "Sheraton",
                HotelLocation = Locations.Bursa,
                CurrencyUnit = CurrencyUnits.Dolar,
                HotelPrice = 200
            },
            new Hotel
            {
                Id = 3,
                HotelName = "Hotel Plaza",
                HotelLocation = Locations.İzmir,
                CurrencyUnit = CurrencyUnits.TL,
                HotelPrice = 100
            },
            new Hotel
            {
                Id = 4,
                HotelName = "Conrad",
                HotelLocation = Locations.İzmir,
                CurrencyUnit = CurrencyUnits.Sterlin,
                HotelPrice = 175
            },
            new Hotel
            {
                Id = 5,
                HotelName = "Amara Family Resort",
                HotelLocation = Locations.Antalya,
                CurrencyUnit = CurrencyUnits.KuveytDinarı,
                HotelPrice = 300
            },
            new Hotel
            {
                Id = 6,
                HotelName = "Angora Beach",
                HotelLocation = Locations.İzmir,
                CurrencyUnit = CurrencyUnits.Coin,
                HotelPrice = 1000
            },
            new Hotel
            {
                Id = 7,
                HotelName = "Ramada",
                HotelLocation = Locations.Muğla,
                CurrencyUnit = CurrencyUnits.TL,
                HotelPrice = 100
            },
            new Hotel
            {
                Id = 8,
                HotelName = "Voyage Torba",
                HotelLocation = Locations.Muğla,
                CurrencyUnit = CurrencyUnits.Euro,
                HotelPrice = 199
            },
            new Hotel
            {
                Id = 9,
                HotelName = "Voyage Belek Golf & Spa",
                HotelLocation = Locations.Antalya,
                CurrencyUnit = CurrencyUnits.Dolar,
                HotelPrice = 200
            },
            new Hotel
            {
                Id = 10,
                HotelName = "Korumar Ephesus Beach & Spa Resort",
                HotelLocation = Locations.Aydın,
                CurrencyUnit = CurrencyUnits.TL,
                HotelPrice = 1659
            },
            new Hotel
            {
                Id = 11,
                HotelName = "Voyage Kemer Golf & Spa",
                HotelLocation = Locations.Antalya,
                CurrencyUnit = CurrencyUnits.Euro,
                HotelPrice = 200
            },
            new Hotel
            {
                Id = 12,
                HotelName = "Marble Arch Hotel By Perili Datça",
                HotelLocation = Locations.Muğla,
                CurrencyUnit = CurrencyUnits.Dolar,
                HotelPrice = 175
            },
            new Hotel
            {
                Id = 13,
                HotelName = "Voyage Torba",
                HotelLocation = Locations.Muğla,
                CurrencyUnit = CurrencyUnits.Euro,
                HotelPrice = 199
            },
            new Hotel
            {
                Id = 14,
                HotelName = "Casa De Playa Hotel",
                HotelLocation = Locations.İzmir,
                CurrencyUnit = CurrencyUnits.Dolar,
                HotelPrice = 210
            },

        };

        public static List<Reservation> Reservations = new List<Reservation>
        {
            new Reservation
            {
                Id = 1,
                ReservationTime = DateTime.Now,
                Customer = Customers[0],
                Hotel = Hotels[0]
            },
            new Reservation
            {
                Id = 2,
                ReservationTime = DateTime.Now,
                Customer = Customers[1],
                Hotel = Hotels[1]
            },
            new Reservation
            {
                Id = 3,
                ReservationTime = DateTime.Now,
                Customer = Customers[2],
                Hotel = Hotels[2]
            },
            new Reservation
            {
                Id = 4,
                ReservationTime = DateTime.Now,
                Customer = Customers[3],
                Hotel = Hotels[3]
            },
            new Reservation
            {
                Id = 5,
                ReservationTime = DateTime.Now,
                Customer = Customers[4],
                Hotel = Hotels[4]
            }
        };
    }
}
