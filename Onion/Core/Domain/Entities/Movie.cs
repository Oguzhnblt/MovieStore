namespace Domain.Entities
{
    public class Movie
    {
        public int MovieID { get; set; }

        public string MovieName { get; set; }

        public DateTime MovieYear { get; set; }

        public Genre? MovieGenre { get; set; }

        public ICollection<Actor>? Actor { get; set; }

        public Director? Director { get; set; }

        public decimal MoviePrice { get; set; }

        public bool IsDeleted { get; set; }



        // Navigation Properties

        public int CustomerID { get; set; }

        public int ActorID { get; set; }

        public int DirectorID { get; set; }

        public int GenreID { get; set; }

    }
}
