using WFAHotelRezervasyon.Entities.Abstract;
using WFAHotelRezervasyon.Enums;


namespace WFAHotelRezervasyon.Entities.Concrete
{
    internal class Hotel : BaseEntities
    {
        public string HotelName { get; set; }
        public Locations HotelLocation { get; set; }
        public AccommodationTypes AccommodationType { get; set; }
        public double Price { get; set; }
        public string Picture { get; set; }

    }
}
