﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityTrackerApi.Data.DTOs
{
    public class RegisterUserDto
    {
        [Required]
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
