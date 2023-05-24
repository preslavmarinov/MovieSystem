using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.DTO
{
    public class MovieListsDTO:MovieDTO
    {
        public List<DirectorDTO> Directors { get; set; }
        public List<ProducingCompanyDTO> ProducingCompanies { get; set; }
        public List<GenreDTO> Genres { get; set; }
    }
}
