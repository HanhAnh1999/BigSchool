using BigSchool.Models;
using BigSchool.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
                //.Include(c => c.Lectuter)
                //.Include(c => c.Category )
                .Where(c => c.Datetime > DateTime.Now);

            return View();

            //var viewModel = new CourseViewModel
            //{
            //    UpcommingCourse = upcommingCourses,
            //    ShowAction = User.Identity.IsAuthenticated
            //};
            //return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}