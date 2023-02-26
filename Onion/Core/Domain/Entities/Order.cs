namespace Domain.Entities
{
    public class Order
    {
        public int OrderID { get; set; }

        public Customer? Customer { get; set; }

        public int CustomerID { get; set; }

        public List<Movie>? PurchasedMovie { get; set; }

        public int MovieID { get; set; }

        public decimal Price { get; set; }

        public DateTime PurchasedDate { get; set; }
    }
}
