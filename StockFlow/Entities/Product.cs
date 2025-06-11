namespace StockFlow.Entities
{
    public class Product
    {
        public  int ProductID { get; set; }
        public  string ProductName { get; set; }
        public  decimal ProductPrice { get; set; }
        public  int ProductStock { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Order> Orders { get; set; }
    }
}
