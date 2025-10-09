using Microsoft.EntityFrameworkCore;
using OctEntityFramework.Models;

using (var context = new SchoolDbContext())
{
    Console.WriteLine($"Database path: {context.DbPath}.");

    /* Add Data */
    // var student = new Student()
    // {
    //     FirstName = "Bill",
    //     LastName = "Gates",
    //     Grade = new Grade()
    //     {
    //         Name = "A"
    //     }

    // };

    // context.Students.Add(student);
    // await context.SaveChangesAsync();

    /* Update Data */
    // var student = await context.Students.FirstAsync();
    // student.FirstName = "Steve";
    // await context.SaveChangesAsync();

    /* Delete Data */
    // var student = await context.Students.FirstAsync();
    // context.Remove(student);
    // await context.SaveChangesAsync();

    /* Add Data */
    var grade = await context.Grades.FirstAsync(g => g.GradeId == 1);
    // var student = new Student()
    // {
    //     FirstName = "Steve",
    //     LastName = "Job",
    //     Grade = grade
    // };
    // await context.Students.AddAsync(student);
    // await context.SaveChangesAsync();

    /* Delete */
    // var student = await context.Students.FirstAsync(s => s.FirstName == "Steve");
    // context.Remove(student);

    // await context.SaveChangesAsync();

    /* Add */
    var steve = new Student()
    {
        FirstName = "Steve",
        LastName = "Jobs",
        Grade = new Grade()
        {
            Name = "B"
        }
    };
    var elon = new Student()
    {
        FirstName = "Elon",
        LastName = "Musk",
        Grade = grade
    };

    var bill = new Student()
    {
        FirstName = "Bill",
        LastName = "Gates",
        Grade = grade
    };

    var mark = new Student()
    {
        FirstName = "Mark",
        LastName = "Zuckerberg",
        Grade = new Grade()
        {
            Name = "B"
        }
    };

    var linus = new Student()
    {
        FirstName = "Linus",
        LastName = "Torvalds",
        Grade = grade
    };

    // await context.Students.AddAsync(steve);
    // await context.Students.AddAsync(elon);
    // await context.Students.AddAsync(bill);
    // await context.Students.AddAsync(mark);
    // await context.Students.AddAsync(linus);

    // await context.SaveChangesAsync();

    await context.Students.AddRangeAsync([steve, elon, bill, mark, linus]);

    await context.SaveChangesAsync();

    var students = await context.Students.Include(s => s.Grade).ToListAsync();

    int i = 1;
    foreach (var student in students)
    {
        Console.WriteLine($"{i} - {student.FirstName} {student.LastName} - {student.Grade.Name}");
        i++;
    }

}