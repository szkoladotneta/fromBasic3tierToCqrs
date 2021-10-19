using Application.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance;
using System;
using System.Linq;

namespace Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MyDbContext _ctx;

        public MovieRepository(MyDbContext ctx)
        {
            _ctx = ctx;
        }

        private IQueryable<Movie> Movies => _ctx.Movies;

        public Movie GetMovieById(int id) => Movies
                .Include(m => m.Producer)
                .Include(m => m.MovieCategory)
                .FirstOrDefault(p => p.MovieId == id);

        public int SaveMovie(Movie movie)
        {
            _ctx.Movies.Add(movie);
            _ctx.SaveChanges();
            return movie.MovieId;
        }
    }
}
