using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Views.ViewModels
{
    public class CustomViewModel : Controller
    {
        // GET: CustomViewModel
        public ActionResult Index()
        {
            return View();
        }
    }
}