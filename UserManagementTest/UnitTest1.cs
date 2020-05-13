using System;
using Xunit;
using UserManagementApplication;
using UserManagementCL;

namespace UserManagementTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Creating User Instance.
            User user = new User();
            user.UserName = "aryan";
            user.Password = "1234";
            //Expected Values.
            string expectedUserName = "aryan";
            string expectedPassword = "1234";
            //Asserting Values.
            Assert.Equal(expectedUserName, user.UserName);
            Assert.Equal(expectedPassword, user.Password);
        }
    }
}
