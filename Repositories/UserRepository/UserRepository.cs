using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicReview.Models;
using BasicReview.Contexts;


namespace BasicReview.Repositories.UserRepository
{
    public class UserRepository : IUserRepository

    {
        public Context _context { get; set; }
        public UserRepository(Context context)
        {
            _context = context;
        }
        public User Create(User users)
        {
            var result = _context.Add<User>(users);
            _context.SaveChanges();
            return result.Entity;
        }
        public User Get(string Id)
        {
            return _context.Users.SingleOrDefault(x => x.Username == Id);
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User Update(User users)
        {
            _context.Entry(users).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return users;
        }

        public User Delete(User users)
        {
            var result = _context.Remove(users);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
