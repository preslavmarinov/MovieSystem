using MovieSystem.Data.Repositories.Interfaces;
using MovieSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public Guid CreateMovie(MovieDTO movie)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllMovies<T>()
        {
            throw new NotImplementedException();
        }

        public MovieDTO GetMovieById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid UpdateMovie(MovieDTO movie)
        {
            throw new NotImplementedException();
        }
    }
}
