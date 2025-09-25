using System;
using System.Collections.Generic;

namespace SchoolClient.Models
{
     public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }

        // Optional: include courses if API returns them
        //public List<Course>? Courses { get; set; }
    }
}
