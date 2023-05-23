using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    internal class User
    {
        private string username;
        private string email;
        private string password;
        private DateTime birthdate;

        public User(string username, string email, string password, DateTime birthdate)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.birthdate = birthdate;
        }

        public string GetUsername()
        {
            return username;
        }

        public void SetUsername(string newUsername)
        {
            username = newUsername;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string newEmail)
        {
            if (newEmail.Contains("@"))
            {
                email = newEmail;
            }
            else
            {
                throw new Exception("Invalid email format.");
            }
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string newPassword)
        {
            password = newPassword;
        }

        public DateTime GetBirthdate()
        {
            return birthdate;
        }

        public void SetBirthdate(DateTime newBirthdate)
        {
            birthdate = newBirthdate;
        }
    }

}
