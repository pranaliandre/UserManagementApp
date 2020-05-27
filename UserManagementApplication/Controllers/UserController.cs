///-----------------------------------------------------------------
///   Class:       UserController
///   Description: User Management API for register,Login,get by id
///   Author:      Pranali Andre                   Date: 28/5/2020
///-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagementBL.Interface;
using UserManagementBL.Services;
using UserManagementCL;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration.Ini;
using Microsoft.Extensions.Configuration;
namespace UserManagementApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        public IUserBL user;

        public UserController(IUserBL user)
        {
            this.user = user;
        }
        // // POST api/Register
        [HttpPost("Register")]
        /// <summary>
        /// API for registration
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IActionResult User_Register(User model)
        {
            try
            {
                bool result = user.User_Register(model);
                if (!result.Equals(null))
                {
                    var status = true;
                    var message = "User Register Successfully.";
                    return this.Ok(new { status, message });
                }
                else
                {
                    var status = false;
                    var message = "User Register Unsuccessfully.";
                    return this.BadRequest(new { status, message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { error = exception.Message });
            }
        }
        // // POST api/Login
        [HttpPost("Login")]
        /// <summary>
        /// API for User Login
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IActionResult Login(LoginCL model)
        {
            try
            {
                bool result = user.Login(model);
                if (!result.Equals(null))
                {
                    var status = true;
                    var message = "User Login Successfully.";
                    return this.Ok(new { status, message });
                }
                else
                {
                    var status = false;
                    var message = "User Login Unsuccessfully.";
                    return this.BadRequest(new { status, message });
                }
            }
            catch (Exception exception)
            {
                return BadRequest(new { error = exception.Message });
            }
        }
    }
}