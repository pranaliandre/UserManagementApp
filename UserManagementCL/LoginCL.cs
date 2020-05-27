///-----------------------------------------------------------------
///   Class:       User
///   Description: Poco class for all User details
///   Author:      Pranali Andre                   Date: 28/5/2020
///-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UserManagementCL
{
    public class LoginCL
    {
        [Required(ErrorMessage = "Email id is required")]
        [RegularExpression("^[a-zA-Z0-9]{1,}([.]?[-]?[+]?[a-zA-Z0-9]{1,})?[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-z]{2,3}([.]?[a-z]{2})?$", ErrorMessage = "E-mail is not valid")]
        public string EmailId { get; set; }

        public string Password { get; set; }
    }
}
