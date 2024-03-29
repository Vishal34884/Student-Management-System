﻿using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models.DTO
{
    public class RegistrationModel
    {
        [Key]
        [Required]
        public string StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*[#$^+=!*()@%&]).{6,}$", ErrorMessage = "Minimum length 6 and must contain  1 Uppercase,1 lowercase, 1 special character and 1 digit")]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
        public string? Role { get; set; }


    }
}
