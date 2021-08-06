using AppointmentScheduler.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduler.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET action Login
        public IActionResult Login()
        {
            return View();
        }

        // GET action Register
        public IActionResult Register()
        {
            return View();
        }
    }
}
