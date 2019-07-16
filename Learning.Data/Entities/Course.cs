using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Data.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Double Duration { get; set; }
        public string Description { get; set; }

        public Tutor CourseTutor { get; set; }
        public Subject CourseSubject { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
