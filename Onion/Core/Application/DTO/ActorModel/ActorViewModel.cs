using Application.DTO.MovieModel;

namespace Application.DTO.ActorDTOModel
{
    public class ActorViewModel
    {

        public int ActorID { get; set; }

        public string ActorName { get; set; }

        public string ActorSurname { get; set; }

        public ICollection<MovieViewModel>? Movies { get; set; }

    }
}

