using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLayer.Models
{
    public class UserLogInViewModel 
    {
        public int Id { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
    }
}
