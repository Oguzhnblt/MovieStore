using Application.DTO.GenreModel;
using Application.DTO.MovieModel;
using Application.DTO.OrderModel;

namespace Application.DTO.CustomerDTOModel
{
    public class CustomerViewModel
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

        public ICollection<MovieViewModel> PurchasedMovies { get; set; }

        public ICollection<GenreViewModel> FavoriteGenres { get; set; }

        public ICollection<OrderViewModel> Orders { get; set; }
    }

}

