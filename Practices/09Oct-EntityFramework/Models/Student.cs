namespace OctEntityFramework.Models;

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int GradeId { get; set; }
    public Grade Grade { get; set; }
}