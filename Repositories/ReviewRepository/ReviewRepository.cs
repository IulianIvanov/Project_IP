using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicReview.Models;
using BasicReview.Contexts;

namespace BasicReview.Repositories.ReviewRepository
{
    public class ReviewRepository : IReviewRepository
    {
        public Context _context { get; set; }
        public ReviewRepository(Context context)
        {
            _context = context;
        }
        public Review Create(Review reviews)
        {
            var result = _context.Add<Review>(reviews);
            _context.SaveChanges();
            return result.Entity;
        }
        public Review Get(int Id)
        {
            return _context.Reviews.SingleOrDefault(x => x.Id == Id);
        }

        public List<Review> GetAll()
        {
            return _context.Reviews.ToList();
        }

        public Review Update(Review reviews)
        {
            _context.Entry(reviews).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return reviews;
        }

        public Review Delete(Review reviews)
        {
            var result = _context.Remove(reviews);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
