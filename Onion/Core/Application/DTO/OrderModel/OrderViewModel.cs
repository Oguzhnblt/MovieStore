using Application.DTO.MovieModel;

namespace Application.DTO.OrderModel
{
    public class OrderViewModel
    {
        public int MovieID { get; set; }
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

        public ICollection<MovieViewModel> PurchasedMovies { get; set; }

        public decimal Price { get; set; }

        public DateTime PurchasedDate { get; set; }
    }
}
