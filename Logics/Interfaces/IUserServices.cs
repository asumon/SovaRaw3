using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logics.Interfaces
{
    public interface IUserServices
    {
        IQueryable<User> GetAllUser();
        IEnumerable<User> GetUserById(int id);
       
    }
}
