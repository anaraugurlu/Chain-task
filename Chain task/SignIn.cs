using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_task
{
    class SignIn : IChain
    {

        public IChain NextChain { get; set; }
        public List<User> Users { get; set; } = new List<User>();

        public void SetNextChain(IChain chain)
        {
            NextChain = chain;
        }

        public void Sign(User user)
        {
            if (user.Sign == "SignIn")
            {
                var User = Users.SingleOrDefault((i) => user.Username == i.Username && user.Password == i.Password);
                if (User != null)
                {
                    user.Sign = "Order";
                    NextChain.Sign(user);
                }
                else
                {
                    Console.WriteLine(" the End ");
                }
            }
            else
            {
                NextChain.Users = Users;
                NextChain.Sign(user);
            }
        }
    }
}
