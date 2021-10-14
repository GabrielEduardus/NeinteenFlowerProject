using NeinteenFlowerProject.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlowerProject.Controller
{
    public class UserLoginController
    {
        public static string loginUser(string email)
        {
            string role = UserLoginHandler.checkRole(email);
            return role;
        }

        public static string validateEmail(string email)
        {
            if (String.IsNullOrWhiteSpace(email)) return "Email must be filled";
            if (!UserLoginHandler.CheckEmail(email)) return "Email is not exist or email is incorrect";

            return null;
        }

        public static string validatePassword(string email, string password)
        {
            if (String.IsNullOrWhiteSpace(password)) return "Password must be filled";
            if (!UserLoginHandler.CheckPassword(email, password)) return "Password is incorrect";

            return null;
        }

        public static string updatePassword(string email, string newPassword)
        {
            UserLoginHandler.updatePassword(email, newPassword);
            return "Change Password Success";
        }

        public static string createCaptcha()
        {
            Random rand = new Random();
            int randNumber = rand.Next(1000);

            string letter = "abcdefghijklmnopqrstuvwxyz";
            string randLetter = new string(Enumerable.Repeat(letter, 3).Select(x => x[rand.Next(x.Length)]).ToArray());

            string captcha = randLetter + randNumber.ToString("000");

            return captcha;
        }

        public static string validateCaptcha(string inputCaptha, string captcha)
        {
            if (!inputCaptha.Equals(captcha)) return "Must be the same as captcha";
            return null;
        }
    }
}