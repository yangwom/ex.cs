namespace Rocket;

public static class Trybe
{
    public static string[] students = { "Luiza", "Bruno", "Patrícia", "Tiago" };

    public static string[] Students
    {
        get { return students; }
        set { students = value; }
    }

    public static int NumberOfStudents
    {
        get { return students.Length; }
    }

    public static bool IsStudent(string name)
    {
        return Array.Exists(students, s => s == name);
    }

    public static void PrintStudents()
    {
        Console.WriteLine(string.Join("\r\n", students));
    }
};