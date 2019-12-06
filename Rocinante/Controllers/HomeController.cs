using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Rocinante.Data;
using Rocinante.Models;

namespace Rocinante.Controllers
{
    
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public static List<Job> jobs = new List<Job>();
        JoobleDAL j = new JoobleDAL();
        

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Results(string keywords, string location)
        {
            JoobleDAL j = new JoobleDAL();
            List<Job> jobs = j.CallJooble(keywords, location);
            return View(jobs);
        }

        public IActionResult AddToTracker(string JobId)
        {
            foreach (Job item  in jobs)
            {
                db.Job.Add(item);
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
