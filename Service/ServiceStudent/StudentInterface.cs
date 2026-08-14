using SchoolManagmnent.Models;

namespace SchoolManagmnent.Service.ServiceStudent;
public interface IStudentInterface
{
    Student GetStudentFromUser();
    Student [] GetAllStudent();
    void PrinStudentInfo(Student student);
    void CreateStudent(Student newStudent);
    void GetStudentByName(string name );
    void DeleteById(Guid studentId);
    void UpdateTeacher(Student student);
    void GetPaginatedStudents(int page,int pageSize);
    void AddStudentRange(params Student[] student );

}