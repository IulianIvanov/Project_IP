using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BasicReview.DTOs;
using BasicReview.Models;
using BasicReview.Repositories.ReviewRepository;



namespace BasicReview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        public ReviewController(IReviewRepository repository)
        {
            IReviewRepository = repository;
        }
        public IReviewRepository IReviewRepository { get; set; }
        // GET: api/Review
        [HttpGet]
        public ActionResult<IEnumerable<Review>> Get()
        {
            return IReviewRepository.GetAll();
        }

        // GET: api/Review/5
        [HttpGet("{id}")]
        public ActionResult<Review> Get(int id)
        {
            return IReviewRepository.Get(id);
        }

        // POST: api/Review
        [HttpPost]
        public Review Post(ReviewDTO value)
        {
            Review model = new Review()
            {
                Author_username = value.Author_username
            };
            return IReviewRepository.Create(model);
        }

        // PUT: api/Review/5
        [HttpPut("{id}")]
        public Review Put(int id, ReviewDTO value)
        {
            Review model = IReviewRepository.Get(id);
            if (value.Author_username != null)
            {
                model.Author_username = value.Author_username;
            }
            return IReviewRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Review Delete(int id)
        {
            Review model = IReviewRepository.Get(id);
            return IReviewRepository.Delete(model);
        }
    }
}
