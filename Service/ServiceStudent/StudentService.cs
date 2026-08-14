namespace SchoolManagmnent.Service.ServiceStudent;
using SchoolManagmnent.Models;
public class StuidentService : IStudentInterface
{
    private  List<Student> students = new List <Student>();
    

    public void AddStudentRange(params Student[] student)
    {
        students.AddRange(student);
    }

    public void CreateStudent(Student newStudent)
    {
        students.Add(newStudent);
    }

    public void DeleteById(Guid studentId)
    {
        Student? student = students.FirstOrDefault(x => x.Id == studentId);
        if(student != null)
        {
            students.Remove(student);
        }
    }

    public List<Student> GetAllStudent()
    {
        return this.students;
    }

    public List<Student>  GetPaginatedStudents(int page, int pageSize)
    {
        return students
            .OrderBy(x => x.FullName)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
            
    }

    public List<Student> GetStudentByName(string name)
    {
        return students
            .Where(x => x.FullName.Contains(name))
            .ToList();
    }

    public int GetStudentCount()
    {
        return students.Count();
    }

    public Student GetStudentFromUser()
    {
        Student student = new Student();
        Console.Write("FullName : ");
        student.FullName = Console.ReadLine();
        Console.Write("Age : ");
        student.Age = int.Parse(Console.ReadLine());
        Console.Write("Course : ");
        student.Course = int.Parse(Console.ReadLine());
        Console.Write("Group Name : ");
        student.GroupName = Console.ReadLine();
        return student;
    }

    public void PrinStudentInfo(Student student)
    {
        Console.WriteLine("=======Student Info=======");
        Console.WriteLine(
            $"""
                Student Info:
                        Id = {student.Id}
                        FullName = {student.FullName}
                        Age = {student.Age}
                        Course = {student.Course}
                        GroupName = {student.GroupName}
                """);
    }

    public void UpdateTeacher(Student student)
    {
        if(student is null)
        {
            Console.WriteLine("Student is not found !!!");
            return;
        }
        foreach(Student storegeStudent in students)
        {
            if(storegeStudent?.Id == student.Id)
            {
                storegeStudent.FullName = student.FullName;
                storegeStudent.Age = student.Age;
                storegeStudent.Course = student.Course;
                storegeStudent.GroupName = student.GroupName;
                Console.WriteLine("Student is Updated successfully");
                return;
            }
        }
        Console.WriteLine("Student is not found ");
    }
}