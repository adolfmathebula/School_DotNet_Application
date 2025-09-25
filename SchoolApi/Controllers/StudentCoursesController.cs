using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;

namespace SchoolApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentCoursesController : ControllerBase
    {
        private readonly SchoolDbContext _context;

        public StudentCoursesController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: api/studentcourses/student/1
        [HttpGet("student/{studentId}")]
        public async Task<ActionResult<IEnumerable<Course>>> GetCoursesForStudent(int studentId)
        {
            var student = await _context.Students
                .Include(s => s.Courses)
                .FirstOrDefaultAsync(s => s.Id == studentId);

            if (student == null) return NotFound();

            return Ok(student.Courses);
        }

        // GET: api/studentcourses/course/1
        [HttpGet("course/{courseId}")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudentsForCourse(int courseId)
        {
            var course = await _context.Courses
                .Include(c => c.Students)
                .FirstOrDefaultAsync(c => c.Id == courseId);

            if (course == null) return NotFound();

            return Ok(course.Students);
        }

        // POST: api/studentcourses/enroll/1/2
        [HttpPost("enroll/{studentId}/{courseId}")]
        public async Task<IActionResult> EnrollStudent(int studentId, int courseId)
        {
            var student = await _context.Students.Include(s => s.Courses)
                                                 .FirstOrDefaultAsync(s => s.Id == studentId);
            var course = await _context.Courses.FindAsync(courseId);

            if (student == null || course == null) return NotFound();

            if (!student.Courses.Contains(course))
                student.Courses.Add(course);

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/studentcourses/unenroll/1/2
        [HttpDelete("unenroll/{studentId}/{courseId}")]
        public async Task<IActionResult> UnenrollStudent(int studentId, int courseId)
        {
            var student = await _context.Students.Include(s => s.Courses)
                                                 .FirstOrDefaultAsync(s => s.Id == studentId);

            if (student == null) return NotFound();

            var course = student.Courses.FirstOrDefault(c => c.Id == courseId);
            if (course == null) return NotFound();

            student.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
