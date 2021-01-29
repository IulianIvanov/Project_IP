using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicReview.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Rating { get; set; }
        public virtual Review Review { get; set; }
    }
}
