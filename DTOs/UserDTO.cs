using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicReview.DTOs
{
    public class UserDTO
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Token { get; set; }
        public string Status { get; set; }
    }
}
