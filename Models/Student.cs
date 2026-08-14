using System.Net;
using System.Security.Cryptography;

namespace SchoolManagmnent.Models;
public class Student
{
    public Guid Id{get; set;} = Guid.NewGuid();
    public string FullName{get;set;}
    private int age;
    private int course;
    public string GroupName{get; set;}
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if(value <= 0)
            {
                Console.WriteLine("Age can not be negative!!!");
            }
            else
            {
                age = value;
            }
        }
    }
    public int Course
    {
        get
        {
            return this.course;
        }
        set
        {
            if(value <= 0 || value >= 6 )
            {
                Console.WriteLine("must be between 1 and 5");
            }
            else
            {
                course = value;
            }
        }
    }

}