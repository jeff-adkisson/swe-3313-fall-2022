using Newtonsoft.Json;

namespace JsonDemo;

public class Student
{
    public Student()
    {
        Enrollments = new Enrollments();
    }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("studentId")] public int StudentId { get; set; }

    [JsonProperty("enrollments")] public Enrollments Enrollments { get; set; }

    public override string ToString()
    {
        return $"Student: {Name}, Id: {StudentId}, Enrolled in: {Enrollments.Count} courses";
    }
}