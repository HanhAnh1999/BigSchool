using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.Views.ViewModels
{
    public class CourseViewModel
    {
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
        public DateTime GetDateTimne()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}