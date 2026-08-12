using System.Dynamic;

namespace SchoolManagmnent.Models;

public class Teacher
{
    public Guid Id{get; set;} = Guid.NewGuid();
    public string FullName{get;set;}
    public string Subjects {get; set;}
    private int experience;
    private int qualificationCategory;
     public int Exprience
    {
        get
        {
            return experience;
        }
        set
        {
            if(value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value),"Experience can not be negative!!!");
            }
            experience = value;
        }
    }
    public int QualificationCategory
    {
        get
        {
            return qualificationCategory;
        }
        set
        {
            if (value > 0 && value < 4)
            {
                qualificationCategory = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value),"Between 1 and 3 category!!!");
            }
        }
    }
}