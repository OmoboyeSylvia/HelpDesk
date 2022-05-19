using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HelpDesk.Models.Request
{
    public class LoginRequest
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
