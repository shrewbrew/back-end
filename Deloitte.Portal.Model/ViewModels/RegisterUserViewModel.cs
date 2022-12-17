using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Mvc;
namespace Deloitte.Portal.Model.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailInUse", controller:"Account")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
