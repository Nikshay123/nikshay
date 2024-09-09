namespace Week5Project.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        // other customer properties
        public ICollection<Order> Orders { get; set; }
    }
}
