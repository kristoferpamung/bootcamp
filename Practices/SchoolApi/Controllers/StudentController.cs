using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApi.DTOs;
using SchoolApi.Models;

namespace SchoolApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolDbContext _context;

        public StudentController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: api/Student
        [HttpGet]
        public async Task<ActionResult<IList<StudentDTO>>> GetStudents()
        {
            var result = await _context.Students.Include(s => s.Enrollments).Select(s => new StudentDTO()
            {
                StudentId = s.StudentId,
                Name = $"{s.FirstName} {s.LastName}",
                Enrollment = s.Enrollments.Select(e => new EnrollmentDTO()
                {
                    EnrollmentId = e.EnrollmentId,
                    CourseName = e.CourseName
                }).ToList()
            }).ToListAsync();
            return result;
        }

        // GET: api/Student/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDTO>> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            var result = new StudentDTO()
            {
                StudentId = student.StudentId,
                Name = $"{student.FirstName} {student.LastName}",
                Enrollment = student.Enrollments.Select(e => new EnrollmentDTO()
                {
                    EnrollmentId = e.EnrollmentId,
                    CourseName = e.CourseName
                }).ToList()
            };

            return result;
        }

        // PUT: api/Student/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            if (id != student.StudentId)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Student
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudentDTO>> PostStudent(CreateStudentRequest createStudent)
        {
            var student = new Student()
            {
                FirstName = createStudent.FirstName,
                LastName = createStudent.LastName
            };
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            var result = new StudentDTO()
            {
                StudentId = student.StudentId,
                Name = $"{student.FirstName} {student.LastName}",
                Enrollment = student.Enrollments.Select(e => new EnrollmentDTO()
                {
                    EnrollmentId = e.EnrollmentId,
                    CourseName = e.CourseName
                }).ToList()
            };

            return CreatedAtAction("GetStudent", new { id = student.StudentId }, result);
        }

        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.StudentId == id);
        }
    }
}
