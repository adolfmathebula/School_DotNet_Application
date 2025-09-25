using System;
using System.Collections.Generic;

namespace SchoolApi.Models;

public partial class Course
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Credits { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
