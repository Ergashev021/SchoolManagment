namespace SchoolManagmnent.Service.ServiceStudent;
using SchoolManagmnent.Models;
public class StuidentService : IStudentInterface
{
    private Student [] students = new Student[10];
    private int count = 0;
    
    public void AddStudentRange(params Student[] student)
    {
        throw new NotImplementedException();
    }

    public void CreateStudent(Student newStudent)
    {
        throw new NotImplementedException();
    }

    public void DeleteById(Guid studentId)
    {
        throw new NotImplementedException();
    }

    public Student[] GetAllStudent()
    {
        throw new NotImplementedException();
    }

    public void GetPaginatedStudents(int page, int pageSize)
    {
        throw new NotImplementedException();
    }

    public void GetStudentByName(string name)
    {
        throw new NotImplementedException();
    }

    public Student GetStudentFromUser()
    {
        throw new NotImplementedException();
    }

    public void PrinStudentInfo(Student student)
    {
        throw new NotImplementedException();
    }

    public void UpdateTeacher(Student student)
    {
        throw new NotImplementedException();
    }
}