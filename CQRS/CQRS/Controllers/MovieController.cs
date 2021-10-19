using Application.Common;
using Application.Movie.Command.AddMovie;
using Application.Movie.Query.GetMovieDetails;
using CQRS.Models;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRS.Controllers
{
    [Route("api/movies")]

    public class MovieController : BaseController
    {

        [HttpGet("{id}")]
        public async Task<ActionResult<MovieDetailsVm>> GetMovie(int id)
        {
            var details = await Mediator.Send(new GetMovieDetailsQuery() { MovieId = id });
            return details;
        }

        [HttpPost]
        public async Task<ActionResult<int>> PostMovie(AddMovieVm model)
        {
            var id = await Mediator.Send(new AddMovieCommand() { NewMovie = model });
            return id;
        }
    }
}
