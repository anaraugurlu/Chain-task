using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_task
{
    class User
    {
        public User(string username, string password, string sign)
        {
            Username = username;
            Password = password;
            Sign = sign;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Sign { get; set; }
    }
}
