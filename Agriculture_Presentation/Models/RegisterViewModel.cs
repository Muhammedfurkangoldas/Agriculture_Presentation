using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture_Presentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz!")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz!")]
        public string mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz!")]
        public string password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz!")]
        [Compare("password",ErrorMessage ="Şifreler Uyumlu Değil, Tekrar Şifrenizi Giriniz!")]
        public string passwordConfirm { get; set; }
    }
}
