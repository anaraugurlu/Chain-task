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
