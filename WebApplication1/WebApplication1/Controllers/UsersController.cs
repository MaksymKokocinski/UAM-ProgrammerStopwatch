using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using Projekt.Models;

namespace Projekt.Controllers
{
    
    public class UsersController : Controller
    {
        private readonly baza_danychContext _context;
        public UsersController(baza_danychContext context)
        {
            _context = context;
        }
        // GET: Users
        public async Task<IActionResult> Index()
        {
            ViewData["login"] = HttpContext.Session.GetString("loginUser");
            ViewData["nameKomorki"] = HttpContext.Session.GetString("name-komorki");
            foreach(var item in _context.tasks)
            {
                foreach(var item2 in _context.holdTime)
                {
                    if(item.id_holdTime==item2.id)
                    {
                        if(item2.time_diffrence==0)
                        {
                            var tAdmin = (int)DateTime.UtcNow.Subtract(new DateTime(2000, 1, 1, 0, 0, 0)).TotalSeconds - (_context.holdTime.Where(x => x.id == item.id_holdTime).FirstOrDefault().time_start);
                            ViewData["continueTime"] = tAdmin;
                        }
                    }
                }
            }
            var model = new Tuple<List<Tasks>,List<holdTime>, List<Userzy>>
                (_context.tasks.ToList(),_context.holdTime.ToList(),_context.userzy.ToList());
            return View(model);
        }

        // GET: Start
        public async Task<IActionResult> Start(int id)
        {
            var check = false;
            foreach(var item in _context.tasks)
            {
                if(item.id==id)
                {
                    if(item.id_holdTime==0)
                    {
                        check = true;
                    }
                }
            }
            if(check)
            {
                var hTime = new holdTime();
                TimeSpan tempTime = DateTime.UtcNow.Subtract(new DateTime(2000, 1, 1, 0, 0, 0));
                hTime.time_start = (int)tempTime.TotalSeconds;
                hTime.time_end = (int)tempTime.TotalSeconds;
                hTime.time_diffrence = 0;
                _context.holdTime.Add(hTime);
                await _context.SaveChangesAsync();
                foreach (var item3 in _context.userzy)
                {
                    if (item3.login == HttpContext.Session.GetString("loginUser"))
                    {
                        _context.tasks.Find(id).id_usera = item3.id;
                    }
                }
                _context.tasks.Find(id).id_holdTime = hTime.id;
                _context.tasks.Find(id).time_user = hTime.time_diffrence;
                await _context.SaveChangesAsync();
                var baza1 = _context.tasks;
                var baza2 = _context.holdTime;
                foreach (var item in baza1)
                {
                    var hTime2 = baza2.Find(item.id_holdTime);
                    if (hTime2 != null)
                    {
                        if (hTime2.time_diffrence == 0)
                        {
                            TimeSpan tempTime2 = DateTime.UtcNow.Subtract(new DateTime(2000, 1, 1, 0, 0, 0));
                            hTime2.time_end = (int)tempTime.TotalSeconds;
                            hTime2.time_diffrence = hTime2.time_end - hTime2.time_start;
                            item.time_user += hTime2.time_diffrence;
                            item.diffrence = item.time_admin - item.time_user;
                        }
                    }
                }
                _context.tasks = baza1;
                _context.holdTime = baza2;
                await _context.SaveChangesAsync();
                HttpContext.Session.SetString("name-komorki", _context.tasks.Find(id).name);
            }
            return RedirectToAction(nameof(Index));
        }
        // GET: Zatrzymaj
        public async Task<IActionResult> Zatrzymaj(int id)
        {
            var hTime = _context.holdTime.Find(_context.tasks.Find(id).id_holdTime);
            TimeSpan tempTime = DateTime.UtcNow.Subtract(new DateTime(2000, 1, 1, 0, 0, 0));
            hTime.time_end = (int)tempTime.TotalSeconds;
            hTime.time_diffrence = hTime.time_end-hTime.time_start;
            await _context.SaveChangesAsync();
            _context.tasks.Find(id).time_user += hTime.time_diffrence;
            await _context.SaveChangesAsync();
            _context.tasks.Find(id).diffrence = _context.tasks.Find(id).time_admin - _context.tasks.Find(id).time_user;
            await _context.SaveChangesAsync();
            HttpContext.Session.SetString("name-komorki", "");
            return RedirectToAction(nameof(Index));
        }
        // GET: Wznow
        public async Task<IActionResult> Wznow(int id)
        {
            var hTime = _context.holdTime.Find(_context.tasks.Find(id).id_holdTime);
            TimeSpan tempTime = DateTime.UtcNow.Subtract(new DateTime(2000, 1, 1, 0, 0, 0));
            hTime.time_start = (int)tempTime.TotalSeconds;
            hTime.time_end = (int)tempTime.TotalSeconds;
            hTime.time_diffrence = 0;
            await _context.SaveChangesAsync();
            var baza1 = _context.tasks;
            var baza2 = _context.holdTime;
            foreach (var item in baza1)
            {
                var hTime2 = baza2.Find(item.id_holdTime);
                if(hTime!=hTime2 && hTime2!=null)
                {
                    if (hTime2.time_diffrence == 0)
                    {
                        TimeSpan tempTime2 = DateTime.UtcNow.Subtract(new DateTime(2000, 1, 1, 0, 0, 0));
                        hTime2.time_end = (int)tempTime.TotalSeconds;
                        hTime2.time_diffrence = hTime2.time_end - hTime2.time_start;
                        item.time_user += hTime2.time_diffrence;
                        item.diffrence = item.time_admin - item.time_user;
                    }
                }
            }
            _context.tasks = baza1;
            _context.holdTime = baza2;
            await _context.SaveChangesAsync();
            HttpContext.Session.SetString("name-komorki", _context.tasks.Find(id).name);
            return RedirectToAction(nameof(Index));
        }
        // GET: Zakoncz
        public async Task<IActionResult> Zakoncz(int id)
        {
            _context.tasks.Find(id).stan = true;
            var hTime = _context.holdTime.Find(_context.tasks.Find(id).id_holdTime);
            if(hTime.time_start==hTime.time_end)
            {
                TimeSpan tempTime = DateTime.UtcNow.Subtract(new DateTime(2000, 1, 1, 0, 0, 0));
                hTime.time_end = (int)tempTime.TotalSeconds;
                hTime.time_diffrence = hTime.time_end - hTime.time_start;
                await _context.SaveChangesAsync();
                _context.tasks.Find(id).time_user += hTime.time_diffrence;
                await _context.SaveChangesAsync();
            }
            _context.tasks.Find(id).diffrence = _context.tasks.Find(id).time_admin - _context.tasks.Find(id).time_user;
            await _context.SaveChangesAsync();
            HttpContext.Session.SetString("name-komorki", "");
            return RedirectToAction(nameof(Index));
        }
        private bool TasksExists(int id)
        {
            return _context.tasks.Any(e => e.id == id);
        }
    }
}
