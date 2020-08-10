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
    public class StudentListsController : Controller
    {
        private readonly DbContextHTP _context;

        public StudentListsController(DbContextHTP context)
        {
            _context = context;
        }

        // GET: StudentLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentLists.ToListAsync());
        }


        // GET: Student/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new StudentList());
            else
                return View(_context.StudentLists.Find(id));
        }

        // POST: Student/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("StudentListId,Title,ShortDescription,FullContent,CoverImg")] StudentList student)
        {
            if (ModelState.IsValid)
            {
                if (student.StudentListId == 0)
                    _context.Add(student);
                else
                    _context.Update(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            var student = await _context.StudentLists.FindAsync(id);
            _context.StudentLists.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
