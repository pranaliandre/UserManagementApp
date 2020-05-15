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
        /// Method for Firstname
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Return_FirstName(User model)
        {
            return "My_FirstName is" + model.FirstName;
        }
        /// <summary>
        /// Method for username
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Return_LastName(User model)
        {
            return "My_LastName is" + model.LastName;
        }
        /// <summary>
        /// Method for emailid
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Return_Email(User model)
        {
            return "My_Email is" + model.EmailId;
        }
        /// <summary>
        /// Method for mobile
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Return_Password(User model)
        {
            return "My_Password is " + model.Password;
        }
        /// <summary>
        /// Method for Mobile number
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Return_Mobile(User model)
        {
            return "My_Mobile is " + model.MobileNo;
        }
        /// <summary>
        /// Method for Address
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Return_Address(User model)
        {
            return "My_Address is " + model.Address;
        }
    }
}
