using BigSchool.Models;
using BigSchool.Views.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Views.COURSE_S
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        //GET: Courses
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categoiries = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Categoiries = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                Datetime = viewModel.GetDateTimne(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place
            };

            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}