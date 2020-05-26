///-----------------------------------------------------------------
///   Class:       Unittest1
///   Description: class for UserManagementtest
///   Author:      Pranali Andre                   Date: 27/5/2020
///-----------------------------------------------------------------
using System;
using Xunit;
using UserManagementApplication;
using UserManagementCL;

namespace UserManagementTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test Case 1.1 Given Empty UserName Should throw Validation Exception.
        /// </summary>
        [Fact]
        public void GivenEmptyUserNameShouldThrowValidationException()
        {
            //Expected Value.
            string expected = "FirstName is required";
            try
            {
                //Creating User Instance.
                User user = new User();
            }
            catch (Exception exception)
            {
                //Asserting Values.
                Assert.Equal(expected, exception.Message);
            }
        }
        /// <summary>
        /// Test Case 1.2 For Checking Encryption Function. 
        /// </summary>
        [Fact]
        public void TestForCheckingEncryptingFunction()
        {
            //Encrypting Strings.
            string encryptedString1 = EncryptedPassword.EncodePasswordToBase("Visual");
            string encryptedString2 = EncryptedPassword.EncodePasswordToBase("Visual");
            //Asserting Values.
            Assert.Equal(encryptedString1, encryptedString2);
        }
    }
}
