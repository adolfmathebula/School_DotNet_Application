using System;
using System.Collections.Generic;

namespace SchoolApi.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
