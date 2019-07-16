﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Enums.Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? LastLoginDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
