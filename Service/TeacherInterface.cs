using SchoolManagmnent.Models;
namespace SchoolManagmnent.Service;


public  interface ITeacherInterface
{
    Teacher GetTeacherFromUser();
    Teacher[] GetAllTeachers();
    void PrintTeacherInfo(Teacher  teacher);
    void Createteacher(Teacher newTeacher);

}