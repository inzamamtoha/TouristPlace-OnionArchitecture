using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IUserLogInService
    {
        UserLogIn MatchUser(string UserId, string Password);
    }
}
