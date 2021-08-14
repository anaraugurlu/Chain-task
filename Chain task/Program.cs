using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_task
{
   

   
   
 
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User("nezrin","nezrin12","SignIn"),
                new User("fatime","fatime123","SignIn"),
                new User("Esger","Esger2003","SignIn"),
                new User("eli","eli20","SignIn"),
                new User("amin","amin","SignIn"),
            };
            SignUp s = new SignUp(users);
            SignIn s2 = new SignIn();
            s.SetNextChain(s2);
            s2.SetNextChain(new OrderChain());
            s.Sign(new User("Fuad", "Fuad123", "SignUp"));
        }
    }
}
