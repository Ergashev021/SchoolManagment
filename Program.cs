using  SchoolManagmnent.Models;
using  SchoolManagmnent.Service;


ITeacherInterface teacherService = new TeacherService();

while (true)
{
    Console.WriteLine("========welcome our school system========");
    Console.WriteLine(" 1. O'qituvchliar ro'yhati ");
    Console.WriteLine(" 2. O'qituvchi qo'shish");
    Console.WriteLine(" 3. Logout ");
    Console.Write("Choose: ");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Teacher[] teachers = teacherService.GetAllTeachers();
            bool hasTeacher = false;
            foreach(var teacher1 in teachers)
            {
                if (teacher1 != null)
                {
                    teacherService.PrintTeacherInfo(teacher1);
                    hasTeacher = true;
                }
             
            }
            if(!hasTeacher)
            {
                Console.WriteLine("Hech qanday o'qituvchi mavjud emas ");
            }
            break;
        case 2:
            var teacher = teacherService.GetTeacherFromUser();
            teacherService.Createteacher(teacher);
            Console.WriteLine("Teacher successfully added!");
            break;
        case 3:
        Console.WriteLine("Good Bye ");
            return;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }
}




































// var Teacher1 = new Teacher
// {
//     Id = 1,
//     FullName = "Ergashev Tursunboy",
//     Subjects = "Informatics",
//     Exprience = 5,
//     QualificationCategory = 2
// };
// var Teacher2 = new Teacher
// {
//     Id = 1,
//     FullName = "Ergashev",
//     Subjects = "Informatics",
//     Exprience = 7,
//     QualificationCategory = 1
// };
// var Teacher3 = new Teacher
// {
//     Id = 1,
//     FullName = "Ergashev mmmm",
//     Subjects = "Informatics",
//     Exprience = 7,
//     QualificationCategory = 2
// };
// ITeacherInterface teacherInterface = new TeacherService();
// teacherInterface.Createteacher(Teacher1);
// teacherInterface.Createteacher(Teacher2);
// teacherInterface.Createteacher(Teacher3);


