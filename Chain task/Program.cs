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
            Sign= sign;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Sign { get; set; }
    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Product(string name,double price,string desc)
        {
            Description = desc;
            Price = price;
            Name = name;
        }
    }
    public class Order
    {
        public string Name { get; set; }
        public decimal Price { get; set; }


        public Order(string name,decimal  price)
        {
            Name = name;
            Price = price;
        }

    }
    
  
    
 
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User("nezrin","nezrin12","SignIn"),
                new User("fatime","fatime123","SignIn"),
                new User("Esger","Esger2003","SignIn"),
            };
            SignUp s = new SignUp(users);
            SignIn s2 = new SignIn();
            s.SetNextChain(s2);
            s2.SetNextChain(new OrderChain());
            s.Sign(new User("Fuad", "Fuad123", "SignUp"));
        }
    }
}
