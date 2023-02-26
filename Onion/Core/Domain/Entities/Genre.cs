namespace Domain.Entities
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public List<Movie>? Movies { get; set; }
    }

}

