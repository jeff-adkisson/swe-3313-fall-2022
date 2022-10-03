namespace JsonToClassTypeBindingNewtonSoft;

public class Person
{
    //NOTE - THIS CLASS CANNOT BE ABSTRACT IF NOT INCLUDING TYPES
    //IT *SHOULD* BE ABSTRACT... make it abstract and try to run and you will get a failure
    //then comment out everything between // jsonWithoutType above, make it abstract, and you
    //will get a better binding and an encapsulated object
    public string Name { get; init; } = "";
    public string Email { get; init; } = "";
    public string Phone { get; init; } = "";

    public override string ToString()
    {
        return $"PERSON -> {Name}, {Email}, {Phone}";
    }
}