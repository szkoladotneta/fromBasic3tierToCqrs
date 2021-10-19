using Application.Common;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Movies2.Queries.GetMovieDetails
{
    public class GetMovieDetailsQueryHandler : IRequestHandler<GetMovieDetailsQuery, MovieDetailsVm>
    {
        private readonly IMyDbContext _ctx;

        public GetMovieDetailsQueryHandler(IMyDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<MovieDetailsVm> Handle(GetMovieDetailsQuery request, CancellationToken cancellationToken)
        {
            var movie = await _ctx.Movies
                .Include(m => m.Producer)
                .Include(m => m.MovieCategory)
                .FirstOrDefaultAsync(p => p.MovieId == request.Id, cancellationToken);
            var vm = MapMovieDetailsFromMovie(movie);

            return vm;
        }

        private MovieDetailsVm MapMovieDetailsFromMovie(Movie? movie)
        {
            return new MovieDetailsVm(movie.MovieId,
                movie.MovieName,
                movie.Director,
                movie.Country,
                movie.Length,
                movie.ReminderDate,
                movie.IsLost,
                movie.LostReason,
                movie.MovieCategory.MovieCategoryName,
                movie.Producer.ProducerName);
        }
    }
}
