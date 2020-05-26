///-----------------------------------------------------------------
///   Class:       IUserRL
///   Description: Repository Layer Interface for user
///   Author:      Pranali                   Date: 27/5/2020
///-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserManagementCL;

namespace UserManagementRL.Interface
{
    public interface IUserRL
    {
        //Interface method for User Registration
        bool User_Register(User model);
    }
}
