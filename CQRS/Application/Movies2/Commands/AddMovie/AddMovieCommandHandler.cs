using Application.Common;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Movies2.Commands.AddMovie
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
            var producer = _ctx.Producers.FirstOrDefault(p => p.ProducerName == request.Movie.ProducerName);
            if (producer == null)
            {
                producer = new Producer() { ProducerName = request.Movie.ProducerName };
                _ctx.Producers.Add(producer);
                _ctx.SaveChanges();
            }

            var movie = MapMovieFromNewMovie(request.Movie, producer);
            _ctx.Movies.Add(movie);
            _ctx.SaveChanges();

            return movie.MovieId;
        }

        private Movie MapMovieFromNewMovie(NewMovieVm model, Producer producer)
        {
            return new Movie()
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
