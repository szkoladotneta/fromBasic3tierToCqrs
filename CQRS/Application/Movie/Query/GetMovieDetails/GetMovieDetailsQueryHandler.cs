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

namespace Application.Movie.Query.GetMovieDetails
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
            var movie = await _ctx.Movies.Include(p => p.MovieCategory).Include(p => p.Producer).FirstOrDefaultAsync(p => p.MovieId == request.MovieId);

            if (movie == null)
            {
                throw new ArgumentException();
            }

            return MapMovieToMovieDetails(movie);
        }

        private MovieDetailsVm MapMovieToMovieDetails(Domain.Entities.Movie movie)
        {
            return new MovieDetailsVm(movie.MovieId, movie.MovieName, movie.Director, movie.Country,
                movie.Length, movie.ReminderDate, movie.IsLost, movie.LostReason, movie.MovieCategoryId, movie.MovieCategory.MovieCategoryName, movie.ProducerId, movie.Producer.ProducerName);
        }
    }
}
