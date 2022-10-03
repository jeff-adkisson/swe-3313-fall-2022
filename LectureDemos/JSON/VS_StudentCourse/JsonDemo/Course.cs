using Newtonsoft.Json;

namespace JsonDemo;

public class Course
{
    public Course()
    {
        Enrollments = new Enrollments();
    }

    [JsonProperty("courseId")] public int CourseId { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("maxSeats")] public int MaxSeats { get; set; }

    [JsonProperty("enrollments")] public Enrollments Enrollments { get; set; }

    public override string ToString()
    {
        return $"Course: {Name}, Id: {CourseId}, MaxSeats: {MaxSeats}, Enrolled: {Enrollments.Count} students";
    }
}