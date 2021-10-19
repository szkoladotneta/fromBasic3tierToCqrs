using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Movies2.Commands.AddMovie
{
    public class AddMovieCommand: IRequest<int>
    {
        public NewMovieVm Movie { get; set; }
    }
}
