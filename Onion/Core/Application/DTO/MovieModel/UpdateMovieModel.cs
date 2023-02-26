using Application.DTO.ActorDTOModel;
using Application.DTO.DirectorModel;
using Domain.Entities;

namespace Application.DTO.MovieModel
{
    internal class UpdateMovieModel
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public DateTime MovieYear { get; set; }
        public Genre? MovieGenre { get; set; }
        public ICollection<ActorViewModel> Actor { get; set; }
        public DirectorViewModel Director { get; set; }
        public decimal MoviePrice { get; set; }
        public bool IsDeleted { get; set; }
    }
}
