using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class UserLogIn : BaseModel
    {
        public string UserId { get; set; }
        public string Password { get; set; }
    } 
}
