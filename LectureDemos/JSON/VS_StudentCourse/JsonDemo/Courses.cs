namespace JsonDemo;

public class Courses : Dictionary<int, Course>
{
    public override string ToString()
    {
        return $"Course List: {Count} courses";
    }
}