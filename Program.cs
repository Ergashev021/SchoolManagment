using  SchoolManagmnent.Models;
using  SchoolManagmnent.Service.ServiceTeacher;


ITeacherInterface teacherService = new TeacherService();

while (true)
{
    Console.WriteLine("========welcome our school system========");
    Console.WriteLine(" 1. O'qituvchliar ro'yhati ");
    Console.WriteLine(" 2. O'qituvchi qo'shish");
    Console.WriteLine(" 3. Id orqali o'qituvchini olish");
    Console.WriteLine(" 4. O'qituvchini yangilash");
    Console.WriteLine(" 5. O'qituvchini Id orqali o'chirish ");
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
            Console.Write("Teacher ID : ");
            Guid id = Guid.Parse(Console.ReadLine()!);
            Teacher? teacherById = teacherService.GetById(id);
            if(teacherById == null)
            {
                Console.WriteLine("Teacher is not found ");
            }
            else
            {
                teacherService.PrintTeacherInfo(teacherById);
            }
            break;
        case 4:
            Console.Write("Teacher Id : ");
            Guid UpdateId = Guid.Parse(Console.ReadLine());
            Teacher? newTeacher = teacherService.GetById(UpdateId);
            if(newTeacher == null)
            {
                Console.WriteLine("Teacher is not found ");
            }
            Console.Write("New FullName: ");
            newTeacher.FullName = Console.ReadLine()!;

            Console.Write("New Subjects: ");
            newTeacher.Subjects = Console.ReadLine()!;

            Console.Write("New Exprience: ");
            newTeacher.Exprience = int.Parse(Console.ReadLine()!);

            Console.Write("New Qualification Category: ");
            newTeacher.QualificationCategory = int.Parse(Console.ReadLine()!);

            teacherService.UpdateTeacher(newTeacher);
            break;
        case 5:
            Console.Write("O'chiriladigan teacher Id ");
            Guid deleteId = Guid.Parse(Console.ReadLine());
            teacherService.DeleteById(deleteId);
            break;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }
}