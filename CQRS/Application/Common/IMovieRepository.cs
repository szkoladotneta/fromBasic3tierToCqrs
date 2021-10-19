using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public interface IMovieRepository
    {
        Domain.Entities.Movie GetMovieById(int id);
        int SaveMovie(Domain.Entities.Movie movie);
    }
}
