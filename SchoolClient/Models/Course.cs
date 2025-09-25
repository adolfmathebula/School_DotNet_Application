using System;
using System.Collections.Generic;

namespace SchoolClient.Models
{

    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int Credits { get; set; }

        // Optional: include students if API returns them
       // public List<Student>? Students { get; set; }
    }
}