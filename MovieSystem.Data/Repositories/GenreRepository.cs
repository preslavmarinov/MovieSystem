using MovieSystem.Data.Repositories.Interfaces;
using MovieSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        public Guid CreateGenre(GenreDTO genre)
        {
            throw new NotImplementedException();
        }

        public void DeleteGenre(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<GenreDTO> GetAllGenres()
        {
            throw new NotImplementedException();
        }

        public GenreDTO GetGenreById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
