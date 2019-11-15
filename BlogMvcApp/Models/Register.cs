using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Your Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Your Surname")]
        public string Surname { get; set; }

        [Required]
        [DisplayName("Username")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Enter your e-mail address correctly.")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Password Again")]
        [Compare("Password", ErrorMessage = "Your passwords do not match.")]
        public string RePassword { get; set; }

    }
}