using HandsOnAPIWithJWT.Entities;
using HandsOnAPIWithJWT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIWithJWT.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MyContext context;

        public UserRepository(MyContext context)
        {
            this.context = context;
        }

        public User? Login(string email,string pwd)
        {
            try
            {
                return context.Users.SingleOrDefault(u => u.Email == email && u.Password == pwd);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Register(User user)
        {
            try
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
