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
        private readonly Dbcontext _context;

        public LoginUsersController(Dbcontext context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
            return View(await _context.loginUsers.ToListAsync());
        }

        
    }
}
