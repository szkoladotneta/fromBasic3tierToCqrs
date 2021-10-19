using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Movies2.Queries.GetMovieDetails
{
    public class GetMovieDetailsQuery : IRequest<MovieDetailsVm>
    {
        public int Id { get; set; }
    }
}
