namespace Application.DTO.CustomerModel
{
    public class UpdateCustomerModel
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

        public ICollection<int> PurchasedMovieIds { get; set; }

        public ICollection<int> FavoriteGenreIds { get; set; }
    }
}

