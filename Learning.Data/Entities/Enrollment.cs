using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Data.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
