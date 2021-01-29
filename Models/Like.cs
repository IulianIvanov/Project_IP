using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicReview.Models
{
    public class Like
    {
        public string Username { get; set; }
        public int Review_id { get; set; }
        public virtual User User { get; set; }
        public virtual Review Review { get; set; }
    }
}
