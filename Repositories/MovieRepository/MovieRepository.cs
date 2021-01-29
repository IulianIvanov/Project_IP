using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicReview.Models;
using BasicReview.Contexts;

namespace BasicReview.Repositories.MovieRepository
{
        public class MovieRepository : IMovieRepository
        {
            public Context _context { get; set; }
            public MovieRepository(Context context)
            {
                _context = context;
            }
            public Movie Create(Movie movies)
            {
                var result = _context.Add<Movie>(movies);
                _context.SaveChanges();
                return result.Entity;
            }
            public Movie Get(int Id)
            {
                return _context.Movies.SingleOrDefault(x => x.Id == Id);
            }

            public List<Movie> GetAll()
            {
                return _context.Movies.ToList();
            }

            public Movie Update(Movie movies)
            {
                _context.Entry(movies).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return movies;
            }

            public Movie Delete(Movie movies)
            {
                var result = _context.Remove(movies);
                _context.SaveChanges();
                return result.Entity;
            }
        }
}
