using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture_Presentation.ViewComponents
{
    public class _MapPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AgricultureContext agricultureContext = new AgricultureContext();
            var value = agricultureContext.Addresses.Select(x => x.Mapinfo).FirstOrDefault();
            ViewBag.v = value;
            return View();
        }
    }
}
