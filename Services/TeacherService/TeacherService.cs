using SchoolManagment.Models;
namespace SchoolManagment.Services.TeacherService;

public class TeacherService : ITeacherService
{
    private readonly List<Teacher> teachers = new();

     public Teacher GetTeacherFromUser()
    {
        Teacher teacher = new Teacher();
        teacher.Id = Guid.NewGuid();
        Console.Write("Full Name : ");
        teacher.FullName = Console.ReadLine();
        Console.Write("Subject: ");
        teacher.Subjects = Console.ReadLine();
        Console.Write("Experience: ");
        teacher.Experience = Convert.ToInt32(Console.ReadLine());

        return teacher;
    }
    public void CreateTeacher(Teacher teacher)
    {
       teachers.Add(teacher);
    }

    public void DeleteTeacherById(Guid teacherId)
    {
       var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
       if(teacher != null)
        {
             teachers.Remove(teacher);
            
        }
            
      
    }

    public List<Teacher> GetAllTeachers()
    {
        return teachers;
    }

   

    public List<Teacher> GetTeachersByName(string name, int pageNumber, int pageSize)
    {
        return teachers
        .Where(t => t.FullName.Contains(name, StringComparison.OrdinalIgnoreCase))
        .Skip((pageNumber - 1) * pageSize)
        .Take(pageSize)
        .ToList();
    }

    public void PrintTeacherInfo(Teacher teacher)
    {
        Console.WriteLine($"Id: {teacher.Id}");
        Console.WriteLine($"Full Name: {teacher.FullName}");
        Console.WriteLine($"Subject: {teacher.Subjects}");
        Console.WriteLine($"Experience: {teacher.Experience}");
    }

    public void UpdateTeacher(Teacher teacher)
    {
        var oldTeacher = teachers.FirstOrDefault(t => t.Id == teacher.Id);

        if (oldTeacher != null)
        {
            oldTeacher.FullName = teacher.FullName;
            oldTeacher.Subjects = teacher.Subjects;
            oldTeacher.Experience = teacher.Experience;
        }
    }
}