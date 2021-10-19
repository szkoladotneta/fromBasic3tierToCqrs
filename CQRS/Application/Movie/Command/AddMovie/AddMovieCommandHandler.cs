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

namespace Application.Movie.Command.AddMovie
{
    public class AddMovieCommandHandler : IRequestHandler<AddMovieCommand, int>
    {
        private readonly IMyDbContext _ctx;

        public AddMovieCommandHandler(IMyDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<int> Handle(AddMovieCommand request, CancellationToken cancellationToken)
        {
            var producent = await _ctx.Producers.FirstOrDefaultAsync(p => p.ProducerName == request.NewMovie.ProducerName);

            if(producent == null)
            {
                producent = new Domain.Entities.Producer() 
                { 
                    ProducerName = request.NewMovie.ProducerName 
                };
                _ctx.Producers.Add(producent);
                _ctx.SaveChanges();
            }

            var movie = MapMovieFromNewMovie(request.NewMovie, producent);

            _ctx.Movies.Add(movie);
            _ctx.SaveChanges();

            return movie.MovieId;
        }

        private Domain.Entities.Movie MapMovieFromNewMovie(AddMovieVm model, Producer producer)
        {
            return new Domain.Entities.Movie()
            {
                ProducerId = producer.ProducerId,
                MovieName = model.MovieName,
                ProjectId = 1,
                ReminderDate = model.ReminderDate,
                Country = model.Country,
                MovieCategoryId = 1,
                IsLost = model.IsLost,
                Director = model.Director,
                Length = model.Length,
                LostReason = model.LostReason,
                MovieId = 0
            };
        }
    }
}
