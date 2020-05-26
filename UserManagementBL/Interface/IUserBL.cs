///-----------------------------------------------------------------
///   Class:       IUserBL
///   Description: UserBL Interface for User
///   Author:      Pranali Andre                  Date: 27/5/2020
///-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserManagementBL.Services;
using UserManagementCL;
namespace UserManagementBL.Interface
{
    public interface IUserBL
    {
        //Interface method for User Registration
        bool User_Register(User model);
    }
}