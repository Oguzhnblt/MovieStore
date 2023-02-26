﻿namespace Domain.Entities
{
    public class Director
    {
        public int DirectorID { get; set; }
        public string DirectorName { get; set; }

        public string DirectorSurname { get; set; }

        public ICollection<Movie>? MoviesDirected { get; set; }
    }
}
