using SchoolManagment.Models;
using SchoolManagment.Services.TeacherService;
using SchoolManagment.Services.StudentService;

TeacherService teacherService = new();
StudentService studentService = new();

string mainChoice;

do
{
    Console.Clear();

    Console.WriteLine("===== School Management =====");
    Console.WriteLine("1. Teacher Management");
    Console.WriteLine("2. Student Management");
    Console.WriteLine("0. Exit");

    Console.Write("Choose: ");
    mainChoice = Console.ReadLine();

    switch (mainChoice)
    {
        case "1":
            TeacherMenu();
            break;

        case "2":
            StudentMenu();
            break;
    }

} while (mainChoice != "0");


// ================= TEACHER MENU =================
void TeacherMenu()
{
    string choice;

    do
    {
        Console.Clear();

        Console.WriteLine("===== Teacher Management =====");
        Console.WriteLine("1. Add Teacher");
        Console.WriteLine("2. Show All Teachers");
        Console.WriteLine("3. Update Teacher");
        Console.WriteLine("4. Delete Teacher");
        Console.WriteLine("5. Search Teacher");
        Console.WriteLine("0. Back");

        Console.Write("Choose: ");
        choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                var teacher = teacherService.GetTeacherFromUser();
                teacherService.CreateTeacher(teacher);

                Console.WriteLine("Teacher Added!");
                Console.ReadKey();
                break;

            case "2":
                var teachers = teacherService.GetAllTeachers();

                foreach (var t in teachers)
                {
                    teacherService.PrintTeacherInfo(t);
                    Console.WriteLine("----------------");
                }

                Console.ReadKey();
                break;

            case "3":
                Console.Write("Enter Teacher ID: ");
                Guid upId = Guid.Parse(Console.ReadLine());

                var upTeacher = teacherService.GetTeacherFromUser();
                upTeacher.Id = upId;

                teacherService.UpdateTeacher(upTeacher);

                Console.WriteLine("Updated!");
                Console.ReadKey();
                break;

            case "4":
                Console.Write("Enter Teacher ID: ");
                Guid delId = Guid.Parse(Console.ReadLine());

                teacherService.DeleteTeacherById(delId);

                Console.WriteLine("Deleted!");
                Console.ReadKey();
                break;

            case "5":
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                var result = teacherService.GetTeachersByName(name, 1, 10);

                foreach (var t in result)
                {
                    teacherService.PrintTeacherInfo(t);
                    Console.WriteLine("----------------");
                }

                Console.ReadKey();
                break;
        }

    } while (choice != "0");
}


// ================= STUDENT MENU =================
void StudentMenu()
{
    string choice;

    do
    {
        Console.Clear();

        Console.WriteLine("===== Student Management =====");
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. Show All Students");
        Console.WriteLine("3. Update Student");
        Console.WriteLine("4. Delete Student");
        Console.WriteLine("5. Search Student");
        Console.WriteLine("6. Show Student Count By Class");
        Console.WriteLine("0. Back");

        Console.Write("Choose: ");
        choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                var student = studentService.GetStudentFromUser();
                studentService.CreateStudent(student);

                Console.WriteLine("Student Added!");
                Console.ReadKey();
                break;

            case "2":
                var students = studentService.GetAllStudents();

                foreach (var s in students)
                {
                    studentService.PrintStudentInfo(s);
                    Console.WriteLine("----------------");
                }

                Console.ReadKey();
                break;

            case "3":
                Console.Write("Enter Student ID: ");
                Guid upId = Guid.Parse(Console.ReadLine());

                var upStudent = studentService.GetStudentFromUser();
                upStudent.Id = upId;

                studentService.UpdateStudent(upStudent);

                Console.WriteLine("Updated!");
                Console.ReadKey();
                break;

            case "4":
                Console.Write("Enter Student ID: ");
                Guid delId = Guid.Parse(Console.ReadLine());

                studentService.DeleteStudentById(delId);

                Console.WriteLine("Deleted!");
                Console.ReadKey();
                break;

            case "5":
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                var result = studentService.GetStudentsByName(name, 1, 10);

                foreach (var s in result)
                {
                    studentService.PrintStudentInfo(s);
                    Console.WriteLine("----------------");
                }

                Console.ReadKey();
                break;
            case "6":
                {
                    studentService.ShowStudentCountByClass();
                    Console.ReadKey();
                    break;
                }
        }

    } while (choice != "0");
}