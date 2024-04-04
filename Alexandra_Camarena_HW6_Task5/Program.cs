// Alexandra Camarena
// MIS HW 6 Task 5

string userChoice;
int numStu = 1;
do
{
    string outMesStr = string.Format($"Student {numStu} name: ");
    Console.Write(outMesStr);
    string nameStr = Console.ReadLine();

    outMesStr = string.Format($"Student {numStu} exam 1 grade: ");
    Console.Write(outMesStr);
    string exam1Str = Console.ReadLine();
    double exam1Grade = Convert.ToDouble(exam1Str);

    outMesStr = string.Format($"Student {numStu} exam 2 grade: ");
    Console.Write(outMesStr);
    string exam2Str = Console.ReadLine();
    double exam2Grade = Convert.ToDouble(exam2Str);

    outMesStr = string.Format($"Student {numStu} exam 3 grade: ");
    Console.Write(outMesStr);
    string exam3Str = Console.ReadLine();
    double exam3Grade = Convert.ToDouble(exam3Str);

    Student stu;
    stu = new Student();
    stu.stuName = nameStr;
    stu.exam1Grade = exam1Grade;
    stu.exam2Grade = exam2Grade;
    stu.exam3Grade = exam3Grade;

    stu.CalculateFinalGrade();
    stu.GetGradeLevel();
    string stuInfor = stu.GetStudentInfor();
    Console.WriteLine(stuInfor);

    Console.Write("\nDo you want to enter another student's information? (yes/no) ");
    userChoice = Console.ReadLine();
    numStu = numStu + 1;

}
while (userChoice == "yes");
Console.WriteLine("Thank you and goodbye!");

Console.ReadKey();

public class Student
{
    public string stuName;
    public double exam1Grade;
    public double exam2Grade;
    public double exam3Grade;
    public double finalGrade;
    public string finalGradeLevel;

    public double CalculateFinalGrade()
    {
        finalGrade = (exam1Grade + exam2Grade + exam3Grade) / 3;
        return finalGrade;
    }
    public string GetGradeLevel()
    {
        if (finalGrade >= 80)
        {
            finalGradeLevel = "level 1";
            return "level 1";
        }
        else if (finalGrade >= 60)
        {
            finalGradeLevel = "Level 2";
            return "level 2";
        }
        else
        {
            finalGradeLevel = "Level 3";
            return "level 3";
        }
    }

    public string GetStudentInfor()
    {
        string stuInforStr = string.Format($"Name: {stuName} Final grade is {finalGrade:F2} It is {finalGradeLevel}!");
        return stuInforStr;
    }
}