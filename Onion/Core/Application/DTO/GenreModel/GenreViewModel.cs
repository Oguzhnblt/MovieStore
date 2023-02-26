using Application.DTO.MovieModel;

namespace Application.DTO.GenreModel
{
    public class GenreViewModel
    {
        public int GenreID { get; set; }

        public string GenreName { get; set; }

        public string Description { get; set; }

        public ICollection<MovieViewModel> Movies { get; set; }
    }

}
