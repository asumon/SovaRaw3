using DomainModels;
using Logics.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SovaDataBase
{
    public class UserServices : IUserServices
    {
       

        public UserServices()
        {
            
        }
        public IQueryable<User> GetAllUser()
        {
            var context = new SovaDbContext();
            var users = context.Users;

            return users;
        }

        public IEnumerable<User> GetUserById(int id)
        {
            var context = new SovaDbContext();
            var userById = context.Users.Where(x => x.Id == id);
            return userById;
        }
    }
}
