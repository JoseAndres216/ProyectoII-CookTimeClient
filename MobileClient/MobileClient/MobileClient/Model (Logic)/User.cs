using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.Model__Logic_
{
    public class User
    {
        public string Email { get; set; }
        //public MyMenu MyMenu { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        //public int Age { get; set; }
        //public int Rating { get; set; }

        public User(string email, string password, string name, int age)
        {
            this.Email = email;
            this.Password = password;
            this.Name = name;
            this.Age = age;
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>()
            {
                new User("jaj","Daniel 'el covid nos va a matar' Salas","pepe", 10)
                ,
                new User("jaj","kobe Bryant","pepe", 10)
                ,
                new User("jaj","Mi maestra de tercer grado","pepe", 10)
                ,
                new User("jaj","Diego de la era del hielo","pepe", 10)
                ,
                new User("jaj","Mary Poppins","pepe", 10)
                ,
                new User("jaj","Daniel 'el covid nos va a matar' Salas","pepe", 10)
                ,
                new User("jaj","kobe Bryant","pepe", 10)
                ,
                new User("jaj","Mi maestra de tercer grado","pepe", 10)
                ,
                new User("jaj","Diego de la era del hielo","pepe", 10)
                ,
                new User("jaj","Mary Poppins","pepe", 10)
                ,
                new User("jaj","Daniel 'el covid nos va a matar' Salas","pepe", 10)
                ,
                new User("jaj","kobe Bryant","pepe", 10)
                ,
                new User("jaj","Mi maestra de tercer grado","pepe", 10)
                ,
                new User("jaj","Diego de la era del hielo","pepe", 10)
                ,
                new User("jaj","Mary Poppins","pepe", 10)
            };
            return users;
        }
    }
}
