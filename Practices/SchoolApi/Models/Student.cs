namespace SchoolApi.Models;
public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public IList<Enrollment> Enrollments { get; set; }
    public Student()
    {
        Enrollments = new List<Enrollment>();
    }
}