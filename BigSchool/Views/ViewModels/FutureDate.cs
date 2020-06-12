using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Views.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        // GET: FutureDate
        public override bool IsValid(object value)
        {
            DateTime dataTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/MM/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dataTime);
            return (isValid && dataTime > DateTime.Now);
        }
    }
}