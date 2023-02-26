namespace Domain.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }



        public ICollection<Movie>? PurchasedMovies { get; set; }

        public ICollection<Genre>? FavoriteGenres { get; set; }

        public ICollection<Order>? Orders { get; set; }


    }
}
