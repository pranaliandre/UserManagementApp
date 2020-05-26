///-----------------------------------------------------------------
///   Class:       EncryptedPassword
///   Description: class validation for password
///   Author:      Pranali Andre                   Date: 27/5/2020
///-----------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace UserManagementCL
{
    public class EncryptedPassword
    {
        /// <summary>
        /// Methof for encryptd password Original string into a Encrypted form that unable to understand for the other user
        /// </summary>
        /// <param name="password">return password encrypted format</param>
        /// <returns></returns>
        public static string EncodePasswordToBase(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch(Exception e)
            {
                throw new Exception("Error in base64Encode" + e.Message);
            }
        }
    }
}
