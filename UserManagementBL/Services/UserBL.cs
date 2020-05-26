///-----------------------------------------------------------------
///   Class:       UserBL
///   Description: UserBL Services for User
///   Author:      Pranali Andre                   Date: 27/5/2020
///-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserManagementBL.Interface;
using UserManagementCL;
using UserManagementRL.Interface;

namespace UserManagementBL.Services
{
    public class UserBL : IUserBL
    {
        private IUserRL user;

        public UserBL(IUserRL user)
        {
            this.user = user;
        }
        /// <summary>
        ///  API for User Registrion
        /// </summary>
        /// <param name="model"> store the Complete User information</param>
        /// <returns></returns>
        public bool User_Register(User model)
        {
            try
            {
                var result = user.User_Register(model);
                if (!result.Equals(null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}