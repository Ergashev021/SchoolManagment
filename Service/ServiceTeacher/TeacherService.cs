namespace SchoolManagmnent.Service.ServiceTeacher;
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
                    Id : {teacher.Id}
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

    public Teacher GetById(Guid teacherId)
    {
        foreach(Teacher teacher in teachers)
        {
            if(teacherId == teacher.Id)
            {
                return teacher;
            }
        }
        return null;
    }

    public void DeleteById(Guid teacherId)
    {
        for(int i = 0;i < this.teachers.Length; i++)
        {
            if(this.teachers[i]?.Id == teacherId)
            {
                this.teachers[i] = null;
                Console.WriteLine("Teacher is successfully deleted ");
            }
        }
        Console.WriteLine("Teacher is not found ");
    }

    public void UpdateTeacher(Teacher teacher)
    {
        if(teacher is null)
        {
            Console.WriteLine("Teacher is not found!!!");
            return;
        }
        foreach(Teacher storegeTeacher in teachers)
        {
            if (storegeTeacher?.Id == teacher.Id)
            {
                storegeTeacher.FullName = teacher.FullName;
                storegeTeacher.Subjects = teacher.Subjects;
                storegeTeacher.Exprience = teacher.Exprience;
                storegeTeacher.QualificationCategory = teacher.QualificationCategory;
                Console.WriteLine("Teacher is successfully updated");
                return ;
            }
        }
        Console.WriteLine("Student is not found ");
    }
}