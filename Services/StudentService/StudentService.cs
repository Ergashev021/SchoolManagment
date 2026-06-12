using SchoolManagment.Models;
using System.Collections.Generic;

namespace SchoolManagment.Services.StudentService;

public class StudentService : IStudentService
{
    private readonly Dictionary<Guid, Student> students = new();
    

    public void CreateStudent(Student student)
    {
        students.Add(student.Id,student);
    }

    public void DeleteStudentById(Guid studentId)
    {
        students.Remove(studentId);
        
    }

    public List<Student> GetAllStudents()
    {
        return students.Values.ToList();
    }

    public Student GetStudentFromUser()
    {
        Student student = new Student();

        student.Id = Guid.NewGuid();

        Console.Write("Full Name: ");
        student.FullName = Console.ReadLine();

        Console.Write("Course: ");
        student.Course = Convert.ToInt32(Console.ReadLine());

        Console.Write("Class Name: ");
        student.ClassName = Console.ReadLine();

        return student;
    }

    public List<Student> GetStudentsByName(string name, int pageNumber, int pageSize)
    {
        return students.Values
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
        Console.WriteLine($"Class Name: {student.ClassName}");
    }

    public void ShowStudentCountByClass()
    {
        Dictionary<string,int> classCounts = new();
        foreach(var student in students.Values)
        {
            if (classCounts.ContainsKey(student.ClassName))
            {
                classCounts[student.ClassName]++;
            }
            else
            {
                classCounts.Add(student.ClassName, 1);
            }
        }
        foreach(var item in classCounts.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} -> {item.Value} ta o'quvchi ");
        }
    }

    public void UpdateStudent(Student student)
    {
        if (students.ContainsKey(student.Id))
        {
            students[student.Id].FullName = student.FullName;
            students[student.Id].Course = student.Course;
            students[student.Id].ClassName = student.ClassName;
        }
         
    }
}