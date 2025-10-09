namespace SchoolApi.Models;
public class Enrollment
{
    public int EnrollmentId { get; set; }
    public string CourseName { get; set; } = string.Empty;
    public int StudentId { get; set; }
    public Student? Student { get; set; }
}