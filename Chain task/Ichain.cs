using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_task
{
    interface IChain
    {
        IChain NextChain { get; set; }
        List<User> Users { get; set; }
        void SetNextChain(IChain chain);
        void Sign(User user);
    }
}
