using System;
using System.Collections.Generic;
using System.Text;
using UserManagementBL.Services;
using UserManagementCL;

namespace UserManagementBL.Interface
{
    public interface IUserBL
    {
        string Return_FirstName(User model);
        string Return_LastName(User model);
        string Return_Email(User model);
        string Return_Password(User model);
        string Return_Mobile(User model);
        string Return_Address(User model);
    }
}
