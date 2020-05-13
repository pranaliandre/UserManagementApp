using System;
using System.Collections.Generic;
using System.Text;
using UserManagementBL.Services;
using UserManagementCL;

namespace UserManagementBL.Interface
{
    public interface IUserBL
    {
        string Return_Name(User model);
        string Return_Password(User model);
    }
}
