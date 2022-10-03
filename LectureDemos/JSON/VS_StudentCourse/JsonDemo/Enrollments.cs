namespace JsonDemo;

public class Enrollments : Dictionary<string, Enrollment>
{
    public void AddEnrollment(Enrollment enrollment)
    {
        var hashKey = GetHashKey(enrollment.StudentId, enrollment.CourseId);
        Add(hashKey, enrollment);
    }

    private static string GetHashKey(int studentId, int courseId) => courseId + "_" + studentId;

    public bool ContainsHashKey(int studentId, Course course) => ContainsKey(GetHashKey(studentId, course.CourseId));

    public override string ToString() => $"Enrollments List: {Count} enrollments";
}