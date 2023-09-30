using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture_Presentation.Models
{
    public class AnnouncementModel
    {
        public int AnnouncementID { get; set; }
        public string AnnouncementTitle { get; set; }
        public string AnnouncementDescription { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public bool AnnouncementStatus { get; set; }
    }
}
