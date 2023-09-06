using Final_SGO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_SGO.Entitys.userEntity;

namespace Final_SGO.Controller
{
    public class userController
    {
        private userDAO userDAO = new userDAO();
        public User GetUser(string username)
        {
            string query = "select User_Id, User_Name, User_Password from Users \" + \"where User_Name=@username";
            User user = userDAO.userGet(query, username);
            return user;
        }
        public bool CheckPassword(string password, User user)
        {
            if (user.Password == password)
            {
                return true;
            }
            return false;
        }
    }
}
