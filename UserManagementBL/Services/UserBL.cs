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
        /// Method for firstname
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public  string Return_FirstName(User model)
        {
            return this.user.Return_FirstName(model);
        }
        /// <summary>
        /// Method for lastname
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Return_LastName(User model)
        {
            return this.user.Return_LastName(model);
        }
        /// <summary>
        /// Method for email
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Return_Email(User model)
        {
            return this.user.Return_Email(model);
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
        /// <summary>
        /// Method for mobile number
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Return_Mobile(User model)
        {
            return this.user.Return_Mobile(model);
        }
        /// <summary>
        /// Method for address
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Return_Address(User model)
        {
            return this.user.Return_Address(model);
        }
    }
}