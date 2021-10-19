using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Movie.Command.AddMovie
{
    public class AddMovieCommand  : IRequest<int>
    {
        public AddMovieVm NewMovie { get; set; }
    }
}
