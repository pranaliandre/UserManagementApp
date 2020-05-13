using System;
using System.Collections.Generic;
using System.Text;
using UserManagementCL;

namespace UserManagementRL.Interface
{
    public interface IUserRL
    {
        string Return_Name(User model);
        string Return_Password(User model);
    }
}
