using MovieSystem.Data.Repositories.Interfaces;
using MovieSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repositories
{
    public class DirectorRepository : IDirectorRepository
    {
        public Guid CreateDirector(DirectorDTO director)
        {
            throw new NotImplementedException();
        }

        public void DeleteDirector(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<DirectorDTO> GetAllDirectors()
        {
            throw new NotImplementedException();
        }

        public DirectorDTO GetDirectorById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid UpdateDirector(DirectorDTO director)
        {
            throw new NotImplementedException();
        }
    }
}
