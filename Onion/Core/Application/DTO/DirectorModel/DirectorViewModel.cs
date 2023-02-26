using Application.DTO.MovieModel;

namespace Application.DTO.DirectorModel
{
    public class DirectorViewModel
    {
        public int DirectorID { get; set; }
        public string DirectorName { get; set; }
        public string DirectorSurname { get; set; }
        public ICollection<MovieViewModel> MoviesDirected { get; set; }
    }
}
