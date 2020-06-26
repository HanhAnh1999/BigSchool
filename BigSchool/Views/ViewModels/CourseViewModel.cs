using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace BigSchool.Views.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Place { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [ValidTime]
        [Required]
        public string Time { get; set; }

        [Required]
        public byte Category { get; set; }

        public IEnumerable<Category> Categoiries { get; set; }
        public List<Category> Categories { get; internal set; }

        public DateTime GetDateTimne()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }

        public string Heading { get; set; }
        public string  Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
        //public static implicit operator CourseViewModel(CourseViewModel v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}