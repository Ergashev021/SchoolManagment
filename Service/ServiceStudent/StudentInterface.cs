using SchoolManagmnent.Models;

namespace SchoolManagmnent.Service.ServiceStudent;
public interface IStudentInterface
{
    Student GetStudentFromUser();
    List<Student> GetAllStudent();
    void PrinStudentInfo(Student student);
    void CreateStudent(Student newStudent);
    List<Student> GetStudentByName(string name );
    void DeleteById(Guid studentId);
    void UpdateTeacher(Student student);
    List<Student> GetPaginatedStudents(int page,int pageSize);
    void AddStudentRange(params Student[] student );
    public int GetStudentCount();
    
}