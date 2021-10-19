using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Movie.Query.GetMovieDetails
{
    public class GetMovieDetailsQuery : IRequest<MovieDetailsVm>
    {
        public int MovieId { get; set; }
    }
}
