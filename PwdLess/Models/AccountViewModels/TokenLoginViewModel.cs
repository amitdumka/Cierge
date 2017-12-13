﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PwdLess.Models.AccountViewModels
{
    public class TokenLoginViewModel
    {   
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Token { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Purpose { get; set; }
    }
}
