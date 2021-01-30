using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BasicReview.DTOs;
using BasicReview.Models;
using BasicReview.Repositories.UserRepository;


namespace BasicReview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController(IUserRepository repository)
        {
            IUserRepository = repository;
        }
        public IUserRepository IUserRepository { get; set; }
        // GET: api/User
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return IUserRepository.GetAll();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(string Username)
        {
            return IUserRepository.Get(Username);
        }

        // POST: api/User
        [HttpPost]
        public User Post(UserDTO value)
        {
            User model = new User()
            {
                Name = value.Name
            };
            return IUserRepository.Create(model);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public User Put(string Username, UserDTO value)
        {
            User model = IUserRepository.Get(Username);
            if (value.Name != null)
            {
                model.Name = value.Name;
            }
            return IUserRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public User Delete(string Username)
        {
            User model = IUserRepository.Get(Username);
            return IUserRepository.Delete(model);
        }
    }
}
