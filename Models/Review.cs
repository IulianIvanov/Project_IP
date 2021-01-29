using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicReview.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Author_username { get; set; }
        public int Movie_id { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public virtual Like Like { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual User User { get; set; }

    }
}
