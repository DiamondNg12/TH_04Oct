using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Data;
using System.Diagnostics;
using TH_04Oct.Models;

namespace TH_04Oct.Controllers
{
    public class LearnerController : Controller
    {
        private SchoolContext db;

        public LearnerController(SchoolContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var learners = db.Learners.Include(major => major.Major).ToArray();

            return View(learners);
        }

        [HttpGet("Create")]
        public IActionResult CreateLearner()
        {
            return View();
        }
    }
}
