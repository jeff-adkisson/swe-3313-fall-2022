namespace JsonDemo;

public class Students : Dictionary<int, Student>
{
    public override string ToString()
    {
        return $"Student List: {Count} students";
    }
}