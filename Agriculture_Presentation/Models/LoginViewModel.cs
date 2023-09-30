using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture_Presentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Girin!")]
        public string userName { get; set; }
        [Required(ErrorMessage ="Lütfen Şifrenizi Girin!")]
        public string password { get; set; }
    }
}
