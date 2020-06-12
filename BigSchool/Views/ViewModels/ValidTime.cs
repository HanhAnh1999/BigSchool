using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Views.ViewModels
{
    public class ValidTine : ValidationAttribute
    {
        // GET: ValidTime
        public override bool IsValid(object value)
        {
            DateTime dataTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dataTime);
            return isValid;
        }
    }
}