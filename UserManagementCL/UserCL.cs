///-----------------------------------------------------------------
///   Class:       User
///   Description: Poco class for all User details
///   Author:      Pranali Andre                   Date: 28/5/2020
///-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace UserManagementCL
{
    public class User
    {
        public string ID { get; set; }
        [Required(ErrorMessage = "FirstName is required")]
        [RegularExpression("^[A-Z]{1}[a-z]{2,}$", ErrorMessage = "User First Name is not valid")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        [RegularExpression("^[A-Z]{1}[a-z]{2,}$", ErrorMessage = "User Last Name is not valid")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email id is required")]
        [RegularExpression("^[a-zA-Z0-9]{1,}([.]?[-]?[+]?[a-zA-Z0-9]{1,})?[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-z]{2,3}([.]?[a-z]{2})?$", ErrorMessage = "E-mail is not valid")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Password Is Required")]
        [RegularExpression("^.{8,15}$", ErrorMessage = "Password Length should be between 8 to 15")]
        public string Password { get; set; }
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Gender Is Required")]
        public string Gender { get; set; }
        public string Address { get; set; }
    }
}