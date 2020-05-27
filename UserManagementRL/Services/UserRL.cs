///-----------------------------------------------------------------
///   Class:       UserRL
///   Description: User Repository and database connectivity using ado.net
///   Author:      Pranali Andre                   Date: 28/5/2020
///-----------------------------------------------------------------
using System;
using System.Threading.Tasks;
using UserManagementCL;
using UserManagementRL.Interface;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Microsoft.Extensions.Configuration;
namespace UserManagementRL.Services
{
    public class UserRL : IUserRL
    {
        //Configration for database : Install package : using Microsoft.Extensions.Configration
        private readonly IConfiguration configuration;
        //Install package System.Data.SqlClient
        private SqlConnection connection = null;
        string constructor = null;
        public UserRL(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// Connection to database
        /// </summary>
        private void Connection()
        {
            try
            {
                //Call the connection string
                constructor = configuration.GetSection("ConnectionStrings").GetSection("UserContext").Value;
                connection = new SqlConnection(constructor);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// database connection for Registrion
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool User_Register(User data)
        {
            try
            {
                // Connect to stored procedure and add in column
                Connection();
                //password encrption
                string Password = EncryptedPassword.EncodePasswordToBase(data.Password);
                SqlCommand command = new SqlCommand("spUserRegister", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FirstName", data.FirstName);
                command.Parameters.AddWithValue("@LastName", data.LastName);
                command.Parameters.AddWithValue("@EmailId", data.EmailId);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@MobileNo", data.MobileNo);
                command.Parameters.AddWithValue("@Gender", data.Gender);
                command.Parameters.AddWithValue("@Address", data.Address);
                // Open Connection UserRegisterManagement Table
                connection.Open();
                // Returns 1 for successful run and 0 For unsuccesful run
                int response = command.ExecuteNonQuery();
                connection.Close();
                if (response != 1)
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
        /// <summary>
        /// Email and Password to check it is correct or not.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Login(LoginCL data)
        {
            try
            {
                string Password = EncryptedPassword.EncodePasswordToBase(data.Password);
                //Connect to stored procedure and add in column
                Connection();
                SqlCommand command = new SqlCommand("spLoginUser", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmailId", data.EmailId);
                command.Parameters.AddWithValue("@Password", Password);
                // Open Connection UserDatails Table
                connection.Open();
                // Execute command
                int response = command.ExecuteNonQuery();
                connection.Close();
                if (response != 1)
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
