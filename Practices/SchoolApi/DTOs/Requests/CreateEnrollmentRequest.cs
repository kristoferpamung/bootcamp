namespace SchoolApi;

public class CreateEnrollmentRequest
{
    public string CourseName { get; set; } = string.Empty;
    public int StudentId { get; set; }
}