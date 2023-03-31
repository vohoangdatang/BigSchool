using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VoHoangDat_1811060166.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<CoursesViewModel> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}