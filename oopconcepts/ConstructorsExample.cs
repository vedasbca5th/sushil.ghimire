public class Student
{
    // Properties of the Student class
    public string Name { get; set; }
    public int Age { get; set; }
    public string Course { get; set; }

    // Default Constructor
    public Student()
    {
        // Default values
        Name = "Unknown";
        Age = 0;
        Course = "Undecided";
    }

    // Parameterized Constructor
    public Student(string name, int age, string course)
    {
        Name = name;
        Age = age;
        Course = course;
    }

    // Static Constructor
    static Student()
    {
        Console.WriteLine("Initializing Student Management System...");
    }

    // Display student information
    public void DisplayInfo()
    {
        Console.WriteLine($"Student Information: {Name}, {Age} years old, Course: {Course}");
    }

    // Static method to display a static message
    public static void DisplayStaticMessage()
    {
        Console.WriteLine("This is a static message from the Student class.");
    }
}

public class ConstructorsExample
{
    static void Main()
    {
        // Using default constructor
        Student defaultStudent = new Student();
        Console.WriteLine("Default Student Information:");
        defaultStudent.DisplayInfo();

        // Using parameterized constructor
        Student alice = new Student("Alice", 20, "Computer Science");
        Console.WriteLine("\nStudent Information (Parameterized Constructor):");
        alice.DisplayInfo();

        // Accessing static method
        Console.WriteLine("\nAccessing static method:");
        Student.DisplayStaticMessage();

        // Creating a list of students
        List<Student> studentList = new List<Student>
        {
            new Student("Bob", 22, "Mathematics"),
            new Student("Charlie", 21, "Physics"),
            new Student("David", 23, "Engineering")
        };

        // Displaying information for all students in the list
        Console.WriteLine("\nStudent List Information:");
        foreach (var student in studentList)
        {
            student.DisplayInfo();
        }
    }
}
