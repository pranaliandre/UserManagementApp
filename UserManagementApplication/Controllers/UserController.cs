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
        [HttpPost]
        public IActionResult Return_Name(User model)
        {
            string original = user.Return_Name(model);
            return Ok(new { original });
        }
        [HttpPost]
        public IActionResult Return_Password(User model)
        {
            string original = user.Return_Password(model);
            return Ok(new { original });
        }
    }
}