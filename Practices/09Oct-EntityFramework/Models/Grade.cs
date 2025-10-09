namespace OctEntityFramework.Models;
public class Grade
{
    public int GradeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Student> Students { get; set; }
    public Grade()
    {
        Students = new List<Student>();
    }
}