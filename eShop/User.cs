using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eShop
{
    public class User
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
            if(String.IsNullOrEmpty(newUsername)) throw new Exception("Username Can't be empty!");
            username = newUsername;
        }

        public string GetEmail()
        {
            return email;
        }

        private static bool IsValidEmail(string input)
        {
            Regex regex = new Regex("^[A-Za-z]+@[A-Za-z]+\\.[A-Za-z0-9]{2,}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(input);
        }

        public void SetEmail(string newEmail)
        {
            if (IsValidEmail(newEmail))
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
            if (String.IsNullOrEmpty(newPassword)) throw new Exception("Password Can't be empty!");
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
    public Cart GetCart()
    {
        return cart;
    }

    public override string ToString()
    {
        return $"Username: {username}\nEmail: {email}\nPassword: {password}\nBirthdate: {birthdate}\n";
    }

}}
