namespace ShopApp.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }

        public string? Code { get; set; }

        public List<Order>? Orders { get; set; }

    }
}
