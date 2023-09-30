using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture_Presentation.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="Başlık boş Geçilemez")]
        public string Title { get; set; }

        [Display(Name = "Görsel")]
        [Required(ErrorMessage = "görsel Değeri boş Geçilemez")]
        public string Image { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama boş Geçilemez")]
        public string Description { get; set; }
    }
}
