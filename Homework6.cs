namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        // Answer Q1 and Q2

        Professor alice = new Professor("Alice", "Java", 9000);
        Professor bob = new Professor("Bob", "Math", 8000);

        Student lisa = new Student("Lisa", "Java", 90);
        Student tom = new Student("Tom", "Math", 80);

        Console.WriteLine($"Professor {alice.ProfName} teaches {alice.ClassTeach}, and the salary is: {alice.Salary}");
        Console.WriteLine($"Professor {bob.ProfName} teaches {bob.ClassTeach}, and the salary is: {bob.Salary}");

        Console.WriteLine($"Student {lisa.StudentName} enrolls {lisa.ClassEnroll}, and the grade is: {lisa.StudentGrade}");
        Console.WriteLine($"Student {tom.StudentName} enrolls {tom.ClassEnroll}, and the grade is: {tom.StudentGrade}");

        double salaryDifference = alice.Salary - bob.Salary;
        Console.WriteLine($"The salary difference between Alice and Bob is: {salaryDifference}");

        double totalGrade = lisa.StudentGrade + tom.StudentGrade;
        Console.WriteLine($"The total grade of Lisa and Tom is: {totalGrade}");
    }
}

class Professor
{
    public string ProfName { get; private set; }
    public string ClassTeach { get; private set; }
    public double Salary { get; private set; }

    public Professor(string profName, string classTeach, double salary)
    {
        ProfName = profName;
        ClassTeach = classTeach;
        Salary = salary;
    }

    public void SetSalary(double salary_amount)
    {
        Salary = salary_amount;
    }

    public double GetSalary()
    {
        return Salary;
    }
}

class Student
{
    public string StudentName { get; private set; }
    public string ClassEnroll { get; private set; }
    public double StudentGrade { get; private set; }

    public Student(string studentName, string classEnroll, double studentGrade)
    {
        StudentName = studentName;
        ClassEnroll = classEnroll;
        StudentGrade = studentGrade;
    }

    public void SetGrade(double newGrade)
    {
        StudentGrade = newGrade;
    }

    public double GetGrade()
    {
        return StudentGrade;
    }
}