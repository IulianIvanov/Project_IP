using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicReview.DTOs
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        public string Author_username { get; set; }
        public int Movie_id { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}
