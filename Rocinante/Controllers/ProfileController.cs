using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Rocinante.Data;
using Rocinante.Models;
using Rocinante.ViewModels;
using Rocinante.Areas.Identity;

namespace Rocinante.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ApplicationDbContext _context;

        public ProfileController(IHostingEnvironment hostingEnvironment,
                                 ApplicationDbContext context)
        {
            this.hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateProfile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProfile(CreateProfileViewModel model)
        {
            if(ModelState.IsValid)
            {
                string uniqueFileName = null; 
                if (model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Photos");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                ApplicationUser newProfile = new ApplicationUser
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    ContactEmail = model.ContactEmail,
                    ContactPhone = model.ContactPhone,
                    City = model.City,
                    PhotoPath = uniqueFileName,
                    ResumePath = uniqueFileName,
                    MakeProfilePublic = model.MakeProfilePublic
                };

                //User.FindFirstValue(ClaimTypes.NameIdentifier);
                _context.Users.Add(newProfile);
                _context.SaveChanges();
            }

            return View();
        }
    }
}