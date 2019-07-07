using System;
using System.ComponentModel.DataAnnotations;

namespace LogAndRegCSharp.Models
{
    public class RegUser
    {
        // First Name
        [Required]
        [MinLength(2)]
        public string fname{get;set;}

        //Last Name
        [Required]
        [MinLength(2)]
        public string lname{get;set;}

        // Email
        [Required]
        [EmailAddress]
        public string email{get;set;}

        // Password
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password{get;set;}


        // Confirm
        [Required]
        [MinLength(8)]
        // [CompareAttribute(CompareField = password, ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        public string confirm{get;set;}
    }
}