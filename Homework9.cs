public class Student
{
    private int studentID;
    private string studentName;
    public string StudentName
    {
        get { return studentName; }
    }
    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
}

public class Homework9
{
    public static void Main(string[] args)
    {
        // 2. In the Program class, the Main method: Create 4 students with the following information
        Student student1 = new Student(111, "Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(333, "Cathy");
        Student student4 = new Student(444, "David");

        // 3. Create a Dictionary named gradebook to hold the student's names and the GPAs
        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };

        // 4. Check if "Tom" has a record in gradebook. If "Tom" is NOT in the gradebook, insert Tom into the gradebook with a GPA of 3.3
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        // 5. Calculate the average GPA of all students, and print out the average GPA.
        double totalGPA = 0;
        foreach (double gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"The average GPA is: {averageGPA}");
        // 6. Finally, print out information about students whose GPA is greater than the average GPA.
        foreach (Student student in Student.studentList)
        {
            if (gradebook.ContainsKey(student.StudentName) && gradebook[student.StudentName] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}