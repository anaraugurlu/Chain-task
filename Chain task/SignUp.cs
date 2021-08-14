using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_task
{
    class SignUp : IChain
    {

        public IChain NextChain { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public SignUp(List<User> users)
        {
            Users = users;
        }

        public void SetNextChain(IChain chain)
        {
            NextChain = chain;
        }

        public void Sign(User user)
        {
            if (user.Sign == "SignUp")
            {
                Users.Add(new User(user.Username, user.Password, "SignIn"));
                user.Sign = "SignIn";
                Console.WriteLine("Sign up ended ");
                NextChain.Users = Users;
                NextChain.Sign(user);
            }
            else
            {
                NextChain.Users = Users;
                NextChain.Sign(user);
            }
        }
    }
}
