namespace JsonToClassTypeBindingNewtonSoft;

public class Customer : Person
{
    public string CreditCard { get; init; } = "";

    public bool CanSeeCreditCard(Person person)
    {
        return person is Manager;
    }

    public override string ToString()
    {
        return $"CUSTOMER -> Credit Card: {CreditCard}\r\n{base.ToString()}";
    }
}