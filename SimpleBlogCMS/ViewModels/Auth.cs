﻿using System.ComponentModel.DataAnnotations;

namespace SimpleBlogCMS.ViewModels
{
    public class AuthLogin
    {
        [Required]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}