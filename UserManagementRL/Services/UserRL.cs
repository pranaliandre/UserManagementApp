using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using UserManagementCL;
using UserManagementRL.Interface;

namespace UserManagementRL.Services
{
    public class UserRL : IUserRL
    {
        /// <summary>
        /// Method for username
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Return_Name(User model)
        {
            return "My_Name is" + model.UserName;
        }
        /// <summary>
        /// Method for password
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Return_Password(User model)
        {
            return "My_Password is " + model.Password;
        }
    }
}
