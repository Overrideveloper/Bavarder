using Bavarder.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bavarder.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Middle name")]
        public virtual string MidName { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Email address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }

        [Required]
        [Display(Name = "Relationship")]
        public Relationship Relationship { get; set; }

        [Required]
        [Display(Name = "Nationality")]
        public Country Country { get; set; }

        [Display(Name = "Profile Photo")]
        public virtual string UserPhoto { get; set; }

        [Display(Name = "Website")]
        public virtual string Website { get; set; }

        [Display(Name = "Bio")]
        [DataType(DataType.MultilineText)]
        public virtual string Bio { get; set; }

        [Display(Name = "Twitter")]
        public virtual string Twitter { get; set; }

        [Display(Name = "Snapchat")]
        public virtual string Snapchat { get; set; }

        [Display(Name = "Phone number")]
        public virtual string PhoneNumber { get; set; }

        [Display(Name = "Date of Birth")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime DOB { get; set; }

        [Display(Name = "Show e-mail on profile?")]
        public virtual bool EmailVisible { get; set; }

        [Display(Name = "Show phone number on profile?")]
        public virtual bool PhoneVisible { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
