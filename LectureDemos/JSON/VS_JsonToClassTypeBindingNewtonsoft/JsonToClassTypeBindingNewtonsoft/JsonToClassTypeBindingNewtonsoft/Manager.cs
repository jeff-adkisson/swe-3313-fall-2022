namespace JsonToClassTypeBindingNewtonSoft;

public class Manager : User
{
    public override string ToString()
    {
        return $"MANAGER\r\n{base.ToString()}";
    }
}