using System;
using System.ComponentModel.DataAnnotations;

namespace LogAndRegCSharp.Models
{
    public class LogUser
    {
        // Email
        [Required]
        [EmailAddress]
        public string email{get;set;}


        // Password
        [Required]
        [DataType(DataType.Password)]
        public string password{get;set;}
    }
}