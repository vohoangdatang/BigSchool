using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VoHoangDat_1811060166.Models;
using VoHoangDat_1811060166.ViewModels;

namespace VoHoangDat_1811060166.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses

        [Authorize]
        [HttpPost]
        public ActionResult Create(CourseViewModel viewModel)
        {
            var course = new Course
            {
                LecturerID = User.Identity.GetUserId(),
                Datetime = viewModel.GetDateTime(),
                CategoryID = viewModel.Category,
                Place = viewModel.Place
            };

            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}