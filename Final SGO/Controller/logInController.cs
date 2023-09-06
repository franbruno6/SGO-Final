using Final_SGO.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Final_SGO.Models;
using static Final_SGO.Entitys.userEntity;

namespace Final_SGO.Controller
{
    internal class logInController
    {
        private userController userController = new userController();
        public bool LogIn(string username, string password)
        {
            User user = userController.GetUser(username);
            bool loggedIn = false;
            if(user.UserName == null)
            {
                return false;
            }
            else
            {
                return loggedIn = userController.CheckPassword(password, user);
            }
        }
        /*public string CalculateHash(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hash)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }*/
    }
}
