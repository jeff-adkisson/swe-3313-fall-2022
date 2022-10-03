namespace JsonToClassTypeBindingNewtonSoft;

public class User : Person
{
    public string Username { get; init; } = "";

    public override string ToString()
    {
        return $"USER -> Username: {Username}\r\n{base.ToString()}";
    }
}