using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.Model.Test
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public IList<Student> Students { get; set; }
    }
}
