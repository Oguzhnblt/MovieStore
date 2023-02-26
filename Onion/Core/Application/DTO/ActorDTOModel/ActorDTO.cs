using Domain.Entities;

namespace Application.DTO.ActorDTOModel
{
    public class ActorDTO
    {
        public string ActorName { get; set; }

        public string ActorSurname { get; set; }

        public ICollection<Movie>? Movies { get; set; }

    }
}

