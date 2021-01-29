using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicReview.Models;
using BasicReview.Contexts;

namespace BasicReview.Repositories.MovieRepository
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        Movie Get(int id);
        Movie Create(Movie movies);
        Movie Update(Movie movies);
        Movie Delete(Movie movies);

    }
}
