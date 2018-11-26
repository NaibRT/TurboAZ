using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Model
{
   public class User
    {
        private static int count=0;


        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Number { get; set; }
        public User(string name,string email,string password,string number)
        {
            ID = count;
            Name = name;
            Email = email;
            Password = password;
            Number = number;
            count++;
        }
    }
}
