using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Rocinante.Data;
using Rocinante.Models;

namespace Rocinante.Controllers
{
    
    public class HomeController : Controller
    {
       readonly ApplicationDbContext db;

        public static List<Job> jobs = new List<Job>();
        JoobleDAL j = new JoobleDAL();

        public HomeController(ApplicationDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Results(string keywords, string location)
        {
            JoobleDAL j = new JoobleDAL();
            jobs = j.CallJooble(keywords, location);
            return View(jobs);
        }
        [Authorize]
        public IActionResult AddToTracker(string jobId)
        {
            Job jb = jobs.FirstOrDefault(x => x.JobId == jobId);
            if (jb != null)
            {                
                jb.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
               
                jb.Id = Guid.NewGuid().ToString();
                    db.Job.Add(jb);
                    db.SaveChanges();               
            }
                
            
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return base.View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
