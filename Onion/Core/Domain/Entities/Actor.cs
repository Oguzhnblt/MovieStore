namespace Domain.Entities
{
    public class Actor
    {
        public int ActorID { get; set; }

        public string ActorName { get; set; }

        public string ActorSurname { get; set; }

        public ICollection<Movie>? Movies { get; set; }

    }

}
