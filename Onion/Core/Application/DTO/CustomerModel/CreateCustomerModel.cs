namespace Application.DTO.CustomerModel
{
    public class CreateCustomerModel
    {
        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

        public ICollection<int> PurchasedMovieIds { get; set; }

        public ICollection<int> FavoriteGenreIds { get; set; }
    }
}

