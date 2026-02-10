using SchoolManagment.Models;
namespace SchoolManagment.Services.TeacherService;
public interface ITeacherService
{
    void CreateTeacher(Teacher teacher);
    List <Teacher> GetAllTEachers();
    void UpdateTeacher(Teacher teacher);
    void DeleteTeacherById(Guid teacherId);
    Teacher GetTeacherFormUser();
    List <Teacher> GetTeachersByName(string name,int pageNumber,int pageSize);
    void PrintTeacherInfo(Teacher teacher);
    

}