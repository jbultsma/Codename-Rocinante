using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rocinante.Data;
using Rocinante.ViewModels;

namespace Rocinante.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProfileController(ApplicationDbContext context)
        {
            _context = context;
        }

        public string LoggedInUser()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        [Authorize]
        public IActionResult Index()
        {
            //var loggedInUser = LoggedInUser();
            //var profile = _context.Users.Where(x => x.Id == User.Identity.Name);

            //return View(profile);

            CreateEmployeViewModel emp = new CreateEmployeViewModel();

            var profile = _context.Users.FirstOrDefault(x => x.UserName == emp.Username);
            return View(profile);
        }
    }
}