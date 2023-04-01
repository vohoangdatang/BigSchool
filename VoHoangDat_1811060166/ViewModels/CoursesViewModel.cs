using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VoHoangDat_1811060166.Models;

namespace VoHoangDat_1811060166.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}