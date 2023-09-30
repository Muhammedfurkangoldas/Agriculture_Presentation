using Agriculture_Presentation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture_Presentation.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ProfileController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.NameUser = values.UserName;
            userEditViewModel.Mail = values.Email;
            userEditViewModel.Phone = values.PhoneNumber;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userEditViewModel.Password==userEditViewModel.PasswordConfirm)
            {
                values.UserName = userEditViewModel.NameUser;
                values.Email = userEditViewModel.Mail;
                values.PhoneNumber = userEditViewModel.Phone;
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, userEditViewModel.Password);
                var result = await _userManager.UpdateAsync(values);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
    }
}
