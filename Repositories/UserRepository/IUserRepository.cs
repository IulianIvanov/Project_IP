using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicReview.Models;
using BasicReview.Contexts;

namespace BasicReview.Repositories.UserRepository
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User Get(string id);
        User Create(User users);
        User Update(User users);
        User Delete(User users);
    }
}
