using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicReview.Models;
using BasicReview.Contexts;

namespace BasicReview.Repositories.ReviewRepository
{
    public interface IReviewRepository
    {
        List<Review> GetAll();
        Review Get(int id);
        Review Create(Review reviews);
        Review Update(Review reviews);
        Review Delete(Review reviews);
    }
}
