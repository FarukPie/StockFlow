namespace StockFlow.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerCity { get; set; }
        public string? CustomerDistrick { get; set; }
        public decimal CustomerBalance { get; set; }
        public string? CustomerImgUrl { get; set; }

        public List<Order> Orders { get; set; }
    }
}
