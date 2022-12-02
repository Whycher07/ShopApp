namespace ShopApp.Data.Entities
{
    public class Order
    {
        private Order? order;

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public float Total { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public string Payment { get; set; }
        public string Status { get; set; }

        public string? Code { get; set; }




    }
}
