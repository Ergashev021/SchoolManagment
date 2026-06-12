using SchoolManagment.Models;

namespace SchoolManagment.Services.StudentService;

public interface IStudentService
{
    Student GetStudentFromUser();
    void CreateStudent(Student student);
    List<Student> GetAllStudents();
    void UpdateStudent(Student student);
    void DeleteStudentById(Guid studentId);
    List<Student> GetStudentsByName(string name, int pageNumber, int pageSize);
    void PrintStudentInfo(Student student);
    void ShowStudentCountByClass();
    
}