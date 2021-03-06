﻿using System.ComponentModel.DataAnnotations;

namespace HastaneYonetim.Core.ViewModel
{
    public class KayitViewModel
    {
        public string Ad { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Eposta { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Sifre")]
        public string Sifre { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "SifreOnay")]
        [Compare("Sifre", ErrorMessage = "The password and confirmation password do not match.")]
        public string SifreOnay { get; set; }

        public bool? AktifMi { get; set; }

    }
}