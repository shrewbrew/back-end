using System;
using System.Collections.Generic;
using System.Text;

namespace Deloitte.Portal.Model.Test
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set;}

        public IList<Course> Courses { get; set; }

    }
}
