using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIWithJWT.Entities;
using HandsOnAPIWithJWT.Model;
namespace HandsOnAPIWithJWT.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);
        User Login(string email,string pwd);
    }
}
