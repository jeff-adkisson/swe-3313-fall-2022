using Newtonsoft.Json;

namespace JsonDemo;

public static class Program
{
    private static void Main()
    {
        //load students and courses from sample data generator
        var students = LoadSampleData.GetStudents();
        var courses = LoadSampleData.GetCourses(students);

        ShowCollections(students, courses);

        //serialize students and courses to JSON
        var coursesJson = JsonConvert.SerializeObject(courses, Formatting.Indented);
        var studentsJson = JsonConvert.SerializeObject(students, Formatting.Indented);

        //show JSON
        Console.WriteLine(coursesJson);
        Console.WriteLine();
        Console.WriteLine(studentsJson);
        Console.WriteLine();

        //set the students and courses collections to null to demonstrate that they are dead
        // ReSharper disable once RedundantAssignment
        students = null;
        // ReSharper disable once RedundantAssignment
        courses = null;

        //deserialize (load) students and courses from JSON
        var studentsFromJson = JsonConvert.DeserializeObject<Students>(studentsJson);
        var coursesFromJson = JsonConvert.DeserializeObject<Courses>(coursesJson);
        ShowCollections(studentsFromJson!, coursesFromJson!); // ! after variable tells C# the value will not be null

        //serialize re-hydrated collections to json and print to examine for equality
        Console.WriteLine(JsonConvert.SerializeObject(coursesFromJson, Formatting.Indented));
        Console.WriteLine();
        Console.WriteLine(JsonConvert.SerializeObject(studentsFromJson, Formatting.Indented));
        Console.WriteLine();
    }

    private static void ShowCollections(Students students, Courses courses)
    {
        int count;
        Console.WriteLine("All STUDENTS in Students collection" + Environment.NewLine);
        foreach (var student in students.Values)
        {
            Console.WriteLine(student);
            count = 1;
            foreach (var enrollment in student.Enrollments.Values) Console.WriteLine($"- {count++:##}: {enrollment}");
            Console.WriteLine();
        }

        Console.WriteLine("All COURSES in Courses collection" + Environment.NewLine);
        foreach (var course in courses.Values)
        {
            Console.WriteLine(course);
            count = 1;
            foreach (var enrollment in course.Enrollments.Values) Console.WriteLine($"- {count++:##}: {enrollment}");
            Console.WriteLine();
        }
    }
}