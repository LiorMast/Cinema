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
        private Cart cart;

        public User(string username, string email, string password, int birthday, int birthdayMonth, int birthdayYear)
        {
            
            SetUsername(username);
            SetEmail(email);
            SetPassword(password);
            SetBirthdate(birthday, birthdayMonth, birthdayYear);
            cart = new Cart();
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
    public void SetBirthdate(int day, int month, int year)
    {
        try
        {
            this.birthdate = new DateTime(year, month, day);
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new Exception("Invalid birthdate.");
        }
    }

    public override string ToString()
    {
        return $"Username: {username}\nEmail: {email}\nPassword: {password}\nBirthdate: {birthdate}\n";
    }

}}
