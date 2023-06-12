﻿using Microsoft.AspNetCore.Mvc;

namespace ArmutProjesi.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()//Giriş 
        {
            return RedirectToAction("Account", "Profile");
        }
        public IActionResult Register()//Kayıt OL
        {
            return View();
        }
        public IActionResult UpdatePassword()//Şifre Yenileme ya da Şifremi Unuttum
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

    }
}
