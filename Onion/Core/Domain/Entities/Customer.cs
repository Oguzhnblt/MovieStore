namespace Domain.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }



        public List<Movie>? PurchasedMovies { get; set; }

        public List<Genre>? FavoriteGenres { get; set; }

        public List<Order>? Orders { get; set; }


    }
}
