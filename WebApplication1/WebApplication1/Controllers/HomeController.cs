using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projekt.Data;
using Projekt.Models;
using Microsoft.AspNetCore.Http;

namespace Projekt.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly baza_danychContext _context;
        public HomeController(baza_danychContext context)
        {
            _context = context;
        }
        public IActionResult Index(bool ?errCheck)
        {
            if(errCheck==true)
            {
                ViewBag.errorCheck = true;
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult Zaloguj(LoginForm texed)
        {
            var check = false;
            foreach(var usr in _context.userzy)
            {
                if(usr.login==texed.Login)
                {
                    if(usr.password==texed.Password)
                    {
                        check = true;
                    }
                }
            }
            if (check)
            {
                HttpContext.Session.SetString("loginUser", texed.Login);
                return RedirectToAction("Index", "Users");
            }
            foreach (var adm in _context.admini)
            {
                if (adm.login == texed.Login)
                {
                    if (adm.password == texed.Password)
                    {
                        check = true;
                    }
                }
            }
            if (check)
            {
                HttpContext.Session.SetString("loginAdmin", texed.Login);
                return RedirectToAction("Index", "Tasks");
            }
            return RedirectToAction("Index", new { errCheck = true });
        }
    }
}
