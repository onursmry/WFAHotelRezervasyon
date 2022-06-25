using WFAHotelRezervasyon.Entities.Abstract;

namespace WFAHotelRezervasyon.Entities.Concrete
{
    internal class Customer:BaseEntities
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
