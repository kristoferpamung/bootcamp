namespace SchoolApi.DTOs;

public class StudentDTO
{
    public int StudentId { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<EnrollmentDTO> Enrollment { get; set; } = [];
}