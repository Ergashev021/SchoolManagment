using SchoolManagmnent.Models;
using SchoolManagmnent.Service.ServiceStudent;
using SchoolManagmnent.Service.ServiceTeacher;

while (true)
{
    Console.WriteLine("=======School managment System=======");
    Console.WriteLine(" 1. Teacher's menu ");
    Console.WriteLine(" 2. Student menu ");
    Console.WriteLine(" 3. Logout ");
    Console.Write("Choose : ");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            ITeacherInterface teacherservice = new TeacherService();
            bool selection = true;
            while (selection)
            {
                Console.WriteLine("=======Teacher's Menu=======");
                Console.WriteLine(" 1. O'qituvchilar ro'yhati ");
                Console.WriteLine(" 2. O'qituvchi qo'shish ");
                Console.WriteLine(" 3. Id orqali o'qituvchi olish ");
                Console.WriteLine(" 4. O'qituvchini yangilash ");
                Console.WriteLine(" 5. O'qituvchini Id orqali o'chirish ");
                Console.WriteLine(" 6. Exit main menu  ");
                Console.Write(" Choose : ");
                int choicet = int.Parse(Console.ReadLine());
                switch (choicet)
                {
                    case 1:
                        Teacher [] teachers = teacherservice.GetAllTeachers();
                        bool hasteacher = false;
                        foreach(var teacher1 in teachers)
                        {
                            if(teacher1 != null)
                            {
                                teacherservice.PrintTeacherInfo(teacher1);
                                hasteacher = true;
                            }
                            if (!hasteacher)
                            {
                                Console.WriteLine("Teacher is not found!!! ");
                            }
                        }
                        break;
                    case 2:
                        var teacher = teacherservice.GetTeacherFromUser();
                        teacherservice.Createteacher(teacher);
                        Console.WriteLine("Teacher successfully added ");
                        break;
                    case 3:
                        Console.Write("Teacher Id : ");
                        Guid id = Guid.Parse(Console.ReadLine());
                        Teacher? teacherById = teacherservice.GetById(id);
                        if(teacherById == null)
                        {
                            Console.WriteLine("Teacher is not found!!!");
                        }
                        else
                        {
                            teacherservice.PrintTeacherInfo(teacherById);
                        }
                        break;
                    case 4:
                        Console.Write("Teacher Id : ");
                        Guid updateId = Guid.Parse(Console.ReadLine());
                        Teacher? newTeacher = teacherservice.GetById(updateId);
                        if(newTeacher == null)
                        {
                            Console.WriteLine(" Teacher is not found!!! ");
                        }
                        Console.Write(" New FullName : ");
                        newTeacher.FullName = Console.ReadLine();
                        Console.Write(" New Subjects : ");
                        newTeacher.Subjects = Console.ReadLine();
                        Console.Write("New Experience : ");
                        newTeacher.Exprience = int.Parse(Console.ReadLine());
                        Console.Write(" Qualification Catorgoryu : ");
                        newTeacher.QualificationCategory = int.Parse(Console.ReadLine());
                        teacherservice.UpdateTeacher(newTeacher);
                        break;
                    case 5:
                        Console.Write(" Teacher Id : ");
                        Guid deleteId = Guid.Parse(Console.ReadLine());
                        teacherservice.DeleteById(deleteId);
                        break;
                    case 6:
                        selection = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect button ");
                        return;
                }
            }

            break;
        case 2:
            IStudentInterface studentService = new StudentService();
            bool selection1 = true;
            while (selection1)
            {
                Console.WriteLine("=====student's Menu=======");
                Console.WriteLine(" 1. Talaba qo'shish ");
                Console.WriteLine(" 2. Talabalar ro'yhati ");
                Console.WriteLine(" 3. Talabalar soni ");
                Console.WriteLine(" 4. Talabalrni ism orqali olish");
                Console.WriteLine(" 5. Talablar qo'shish ");
                Console.WriteLine(" 6. Talaba yangilash ");
                Console.WriteLine(" 7. Talabalarni Paginate qilib olish ");
                Console.WriteLine(" 8. Talaba o'chirish ");
                Console.WriteLine(" 9. Exit main menu ");
                Console.Write("Choose ");
                int choiceS = int.Parse(Console.ReadLine());
                switch (choiceS)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9: 
                        break;
                    default:
                        Console.WriteLine("Incorrect buttun");
                        return;
                }
            }
            break;
        case 3:
            return;
        default:
            Console.WriteLine("Incorrect buttun !!!");
            break;
            
    }
}