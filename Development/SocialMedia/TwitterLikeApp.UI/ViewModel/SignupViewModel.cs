﻿using System.ComponentModel.DataAnnotations;

namespace TwitterLikeApp.UI.ViewModel
{
    public class SignupViewModel
    {
        [Required(ErrorMessage = "Please enter your desired username")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Please enter a password.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string Password2 { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
    }
}