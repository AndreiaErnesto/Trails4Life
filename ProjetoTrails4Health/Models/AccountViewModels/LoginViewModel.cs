﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTrails4Health.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        //[EmailAddress]

        [Display(Name = "Nome")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Lembra-me?")]
        public bool RememberMe { get; set; }
    }
}
