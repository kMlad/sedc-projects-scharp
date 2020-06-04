using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace Task1
{
    class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public User(int Id, string Username, string Password, string[] Messages)
        {
            this.Id = Id;
            this.Username = Username;
            this.Password = Password;
            this.Messages = Messages;
        }

        public User(int Id, string Username, string Password)
        {
            this.Id = Id;
            this.Username = Username;
            this.Password = Password;
        }
    }
}
