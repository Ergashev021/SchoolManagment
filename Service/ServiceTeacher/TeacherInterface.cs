using SchoolManagmnent.Models;
namespace SchoolManagmnent.Service.ServiceTeacher;


public  interface ITeacherInterface
{
    Teacher GetTeacherFromUser();
    Teacher[] GetAllTeachers();
    void PrintTeacherInfo(Teacher  teacher);
    void Createteacher(Teacher newTeacher);
    Teacher GetById(Guid teacherId);
    void DeleteById(Guid teacherId);
    void UpdateTeacher(Teacher teacher);

}