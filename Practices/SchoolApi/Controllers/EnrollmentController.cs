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
    public class EnrollmentController : ControllerBase
    {
        private readonly SchoolDbContext _context;

        public EnrollmentController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: api/Enrollment
        [HttpGet]
        public async Task<ActionResult<IList<EnrollmentDTO>>> GetEnrollments()
        {
            var enrollments = await _context.Enrollments.Select(e => new EnrollmentDTO()
            {
                EnrollmentId = e.EnrollmentId,
                CourseName = e.CourseName
            }).ToListAsync();


            return Ok(enrollments);
        }

        // GET: api/Enrollment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Enrollment>> GetEnrollment(int id)
        {
            var enrollment = await _context.Enrollments.FindAsync(id);

            if (enrollment == null)
            {
                return NotFound();
            }

            return enrollment;
        }

        // PUT: api/Enrollment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnrollment(int id, Enrollment enrollment)
        {
            if (id != enrollment.EnrollmentId)
            {
                return BadRequest();
            }

            _context.Entry(enrollment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnrollmentExists(id))
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

        // POST: api/Enrollment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EnrollmentDTO>> PostEnrollment(CreateEnrollmentRequest enrollmentRequest)
        {
            var enrollment = new Enrollment()
            {
                CourseName = enrollmentRequest.CourseName,
                StudentId = enrollmentRequest.StudentId
            };
            _context.Enrollments.Add(enrollment);
            await _context.SaveChangesAsync();

            var createdEnrollment = await _context.Enrollments.FirstAsync(e => e.CourseName == enrollment.CourseName);

            var result = new EnrollmentDTO()
            {
                EnrollmentId = createdEnrollment.EnrollmentId,
                CourseName = enrollment.CourseName
            };

            return Ok(result);
        }

        // DELETE: api/Enrollment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnrollment(int id)
        {
            var enrollment = await _context.Enrollments.FindAsync(id);
            if (enrollment == null)
            {
                return NotFound();
            }

            _context.Enrollments.Remove(enrollment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EnrollmentExists(int id)
        {
            return _context.Enrollments.Any(e => e.EnrollmentId == id);
        }
    }
}
