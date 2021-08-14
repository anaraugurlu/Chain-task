using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_task
{
    class OrderChain : IChain
    {

        public IChain NextChain { get; set; }
        public List<User> Users { get; set; } = new List<User>();

        public void SetNextChain(IChain chain)
        {
            NextChain = chain;
        }

        public void Sign(User user)
        {
            if (user.Sign == "Order")
            {
                Console.WriteLine(" order  ");
            }
            else
            {
                Console.WriteLine(" end ");
            }
        }
    }
}
