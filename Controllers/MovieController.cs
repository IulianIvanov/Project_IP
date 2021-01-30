using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BasicReview.DTOs;
using BasicReview.Models;
using BasicReview.Repositories.MovieRepository;


namespace BasicReview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public MovieController(IMovieRepository repository)
        {
            IMovieRepository = repository;
        }
        public IMovieRepository IMovieRepository { get; set; }
        // GET: api/Movie
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            return IMovieRepository.GetAll();
        }

        // GET: api/Movie/5
        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            return IMovieRepository.Get(id);
        }

        // POST: api/Movie
        [HttpPost]
        public Movie Post(MovieDTO value)
        {
            Movie model = new Movie()
            {
                Name = value.Name
            };
            return IMovieRepository.Create(model);
        }

        // PUT: api/Movie/5
        [HttpPut("{id}")]
        public Movie Put(int id, MovieDTO value)
        {
            Movie model = IMovieRepository.Get(id);
            if (value.Name != null)
            {
                model.Name = value.Name;
            }
            return IMovieRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Movie Delete(int id)
        {
            Movie model = IMovieRepository.Get(id);
            return IMovieRepository.Delete(model);
        }
    }
}
