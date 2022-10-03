namespace JsonDemo;

public static class LoadSampleData
{
    private const int StudentsToGenerate = 20;
    private const int CoursesPerStudentToGenerate = 5;
    
    private static readonly Random Random = new(2018);

    public static Students GetStudents()
    {
        var students = new Students();
        for (var studentId = 1; studentId <= StudentsToGenerate; studentId++)
        {
            var student = new Student { Name = $"First{studentId} Last{studentId}", StudentId = studentId };
            students.Add(studentId, student);
        }

        return students;
    }

    //avoid writing code this way in practice...
    //the cyclomatic complexity is high with all of those nested loops
    public static Courses GetCourses(Students students)
    {
        var courses = new Courses();

        for (var courseId = 1; courseId <= CoursesPerStudentToGenerate; courseId++)
        {
            var course = new Course
            {
                CourseId = courseId,
                Name = $"Sample Course {courseId}",
                MaxSeats = Random.Next(1, students.Count + 1)
            };
            for (var studentId = 1; studentId <= course.MaxSeats; studentId++)
            {
                int studentIdToEnroll;
                while (true)
                {
                    studentIdToEnroll = Random.Next(1, students.Count + 1);
                    if (!course.Enrollments.ContainsHashKey(studentIdToEnroll, course)) break;
                }

                var student = students[studentIdToEnroll];
                var enrollment = new Enrollment
                    { EnrolledOn = DateTime.Now, CourseId = course.CourseId, StudentId = student.StudentId };
                course.Enrollments.AddEnrollment(enrollment);
                student.Enrollments.AddEnrollment(enrollment);
            }

            courses.Add(course.CourseId, course);
        }

        return courses;
    }
}