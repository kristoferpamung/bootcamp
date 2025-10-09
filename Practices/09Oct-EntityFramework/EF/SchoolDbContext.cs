using Microsoft.EntityFrameworkCore;
using OctEntityFramework.Models;

public class SchoolDbContext : DbContext
{
    // Entities
    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public string DbPath { get; }
    public SchoolDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "school.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }

}