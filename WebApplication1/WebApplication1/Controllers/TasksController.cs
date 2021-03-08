using System;
using System.Collections.Generic;
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
    public class TasksController : Controller
    {
        private readonly baza_danychContext _context;

        public TasksController(baza_danychContext context)
        {
            _context = context;
        }

        // GET: Tasks
        public async Task<IActionResult> Index()
        {
            ViewData["login"] = HttpContext.Session.GetString("loginAdmin");
            return View(await _context.tasks.ToListAsync());
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
            ViewData["login"] = HttpContext.Session.GetString("loginAdmin");
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,time_admin")] Tasks tasks)
        {
            if (ModelState.IsValid)
            {
                tasks.stan = false;
                _context.Add(tasks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tasks);
        }

        // GET: Tasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            
            ViewData["login"] = HttpContext.Session.GetString("loginAdmin");
            if (id == null)
            {
                return NotFound();
            }

            var tasks = await _context.tasks.FindAsync(id);
            if (tasks == null)
            {
                return NotFound();
            }
            if (_context.tasks.Find(id).stan)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(tasks);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,time_admin")] Tasks tasks)
        {
            if (id != tasks.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var taskbar = _context.tasks.AsNoTracking().FirstOrDefault(t => t.id == id);
                    tasks.time_user = taskbar.time_user;
                    tasks.diffrence = tasks.time_admin - tasks.time_user;
                    tasks.id_holdTime = taskbar.id_holdTime;
                    tasks.stan = taskbar.stan;
                    _context.Update(tasks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TasksExists(tasks.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tasks);
        }

        // GET: Tasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewData["login"] = HttpContext.Session.GetString("loginAdmin");
            if (id == null)
            {
                return NotFound();
            }

            var tasks = await _context.tasks
                .FirstOrDefaultAsync(m => m.id == id);
            if (tasks == null)
            {
                return NotFound();
            }
            var tasksin = await _context.tasks.FindAsync(id);
            _context.tasks.Remove(tasksin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TasksExists(int id)
        {
            return _context.tasks.Any(e => e.id == id);
        }
    }
}
