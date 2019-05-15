using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Model;

namespace ServiceLayer
{
    public class UserLogInService : IUserLogInService
    {
        private readonly ITPRepository<UserLogIn> _userLogInRepository;

        public UserLogInService(ITPRepository<UserLogIn> userLogInRepository)
        {
            _userLogInRepository = userLogInRepository;
        }

        public UserLogIn MatchUser(string UserId, string Password)
        {
            return _userLogInRepository.GetAll().Where(u => u.UserId == UserId && u.Password == Password).FirstOrDefault();
        }
    }
}
