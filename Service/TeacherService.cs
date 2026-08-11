namespace SchoolManagmnent.Service;
using SchoolManagmnent.Models;

public class TeacherService : ITeacherInterface
{
    public TeacherService()
    {
        
    }
    private Teacher [] teachers = new Teacher[10];
    private int count = 0;
    public void Createteacher(Teacher newTeacher)
    {
        this.teachers[count] = newTeacher;
        count++;
    }

    public Teacher[] GetAllTeachers()
    {
        return this.teachers;
    }

    public void PrintTeacherInfo(Teacher teacher)
    {
        Console.WriteLine("=========School Managment========");
        Console.WriteLine(
            $""" 
            Teacher Info:
                    Full Name: {teacher.FullName}
                    Subjects : {teacher.Subjects}
                    Experience:{teacher.Exprience}
                    Qualification Catagory: {teacher.QualificationCategory}
            """);
    }

    public Teacher GetTeacherFromUser()
    {
        Teacher teacher = new Teacher();
        Console.Write("FullName : ");
        teacher.FullName = Console.ReadLine();
        Console.Write("Subjects : ");
        teacher.Subjects = Console.ReadLine();
        Console.Write("Exprience : ");
        teacher.Exprience = int.Parse( Console.ReadLine());
        Console.Write("Qualification Catagory : ");
        teacher.QualificationCategory = int.Parse(Console.ReadLine());
        return teacher;
    }
}