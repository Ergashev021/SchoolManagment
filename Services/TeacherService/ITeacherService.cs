using SchoolManagment.Models;
namespace SchoolManagment.Services.TeacherService;
public interface ITeacherService
{
    Teacher GetTeacherFromUser();
    void CreateTeacher(Teacher teacher);
    List <Teacher> GetAllTeachers();
    void UpdateTeacher(Teacher teacher);
    void DeleteTeacherById(Guid teacherId);
    List <Teacher> GetTeachersByName(string name,int pageNumber,int pageSize);
    void PrintTeacherInfo(Teacher teacher);
    

}