using System;
using System.Collections.Generic;
using System.Text;
using UserManagementBL.Interface;
using UserManagementCL;
namespace UserManagementBL.Services
{
    public class UserBL : IUserBL
    {
        /// <summary>
        /// variable
        /// </summary>
        private IUserBL user;
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="user"></param>
        public UserBL(IUserBL user)
        {
            this.user = user;
        }
        /// <summary>
        /// Method for username
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public  string Return_Name(User model)
        {
            return this.user.Return_Name(model);
        }
        /// <summary>
        /// Method for password
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Return_Password(User model)
        {
            return this.user.Return_Password(model);
        }
        
    }
}