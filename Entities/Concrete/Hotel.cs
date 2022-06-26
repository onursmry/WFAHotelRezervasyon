using WFAHotelRezervasyon.Entities.Abstract;
using WFAHotelRezervasyon.Enums;


namespace WFAHotelRezervasyon.Entities.Concrete
{
    public class Hotel : BaseEntities
    {
        public string HotelName { get; set; }
        public Locations HotelLocation { get; set; }
        public AccommodationTypes AccommodationType { get; set; }
        public double HotelPrice { get; set; }
        public CurrencyUnits CurrencyUnit { get; set; }
        public string Picture { get; set; }

    }
}
