namespace ShopApp.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Price { get; set; }
        public int UnitId { get; set; }
        public Unit? Unit { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int Quantity { get; set; }


        public string? Code { get; set; }
    }
}



