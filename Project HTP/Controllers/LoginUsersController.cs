using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_HTP.Models;

namespace Project_HTP.Controllers
{
    public class LoginUsersController : Controller
    {
        private readonly DbContextHTP _context;

        public LoginUsersController(DbContextHTP context)
        {
            _context = context;
        }

        // GET: LoginUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoginUsers.ToListAsync());
        }

        // GET: LoginUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginUser = await _context.LoginUsers
                .FirstOrDefaultAsync(m => m.LoginID == id);
            if (loginUser == null)
            {
                return NotFound();
            }

            return View(loginUser);
        }

        // GET: LoginUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoginUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoginID,Account,Password,NameUser")] LoginUser loginUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loginUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loginUser);
        }

        // GET: LoginUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginUser = await _context.LoginUsers.FindAsync(id);
            if (loginUser == null)
            {
                return NotFound();
            }
            return View(loginUser);
        }

        // POST: LoginUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LoginID,Account,Password,NameUser")] LoginUser loginUser)
        {
            if (id != loginUser.LoginID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loginUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoginUserExists(loginUser.LoginID))
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
            return View(loginUser);
        }

        // GET: LoginUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginUser = await _context.LoginUsers
                .FirstOrDefaultAsync(m => m.LoginID == id);
            if (loginUser == null)
            {
                return NotFound();
            }

            return View(loginUser);
        }

        // POST: LoginUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loginUser = await _context.LoginUsers.FindAsync(id);
            _context.LoginUsers.Remove(loginUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoginUserExists(int id)
        {
            return _context.LoginUsers.Any(e => e.LoginID == id);
        }
    }
}
