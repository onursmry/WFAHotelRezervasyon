using WFAHotelRezervasyon.Entities.Abstract;

namespace WFAHotelRezervasyon.Entities.Concrete
{
    public class Customer:BaseEntities
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
