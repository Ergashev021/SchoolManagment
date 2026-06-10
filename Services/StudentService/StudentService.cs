using SchoolManagment.Models;

namespace SchoolManagment.Services.StudentService;

public class StudentService : IStudentService
{
    private readonly List<Student> students = new();
    

    public void CreateStudent(Student student)
    {
        students.Add(student);
    }

    public void DeleteStudentById(Guid studentId)
    {
         var student = students.FirstOrDefault(s => s.Id == studentId);

        if (student != null)
        {
            students.Remove(student);
        }
    }

    public List<Student> GetAllStudents()
    {
        return students;
    }

    public Student GetStudentFromUser()
    {
         Student student = new Student();

        student.Id = Guid.NewGuid();

        Console.Write("Full Name: ");
        student.FullName = Console.ReadLine();

        Console.Write("Course: ");
        student.Course = Convert.ToInt32(Console.ReadLine());

        return student;
    }

    public List<Student> GetStudentsByName(string name, int pageNumber, int pageSize)
    {
        return students
            .Where(s => s.FullName.Contains(name, StringComparison.OrdinalIgnoreCase))
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }

    public void PrintStudentInfo(Student student)
    {
        Console.WriteLine($"Id: {student.Id}");
        Console.WriteLine($"Full Name: {student.FullName}");
        Console.WriteLine($"Course: {student.Course}");
    }

    public void UpdateStudent(Student student)
    {
         var oldStudent = students.FirstOrDefault(s => s.Id == student.Id);

        if (oldStudent != null)
        {
            oldStudent.FullName = student.FullName;
            oldStudent.Course = student.Course;
        }
    }
}