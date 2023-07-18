﻿namespace WebApplication1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public List<Course> CoursesEnrolled { get; set; }

    }
}
