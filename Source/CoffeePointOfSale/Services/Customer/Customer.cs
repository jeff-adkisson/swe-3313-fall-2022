using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Customer;

public class Customer
{
    public const string AnonymousCustomerId = "anonymous";

    private string _firstName = "";
    private string _lastName = "";
    private string _phone = ""; //backing field for Phone property. only needed because the setter has logic to handle nulls and trimming spaces.
    private int _rewardPoints;

    public virtual string FirstName
    {
        get => _firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("First Name cannot be empty or null");
            _firstName = value.Trim();
        }
    }
    public virtual string LastName
    {
        get => _lastName;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Last Name cannot be empty or null");
            _lastName = value.Trim();
        }
    }
    public virtual string Phone
    {
        get => _phone;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Phone cannot be empty or null");
            _phone = value.Trim(); //trim to remove leading or trailing spaces that might mess up the lookup function
        }
    }

    public virtual int RewardPoints

    {
        get => _rewardPoints;
        set
        {
            if (IsAnonymous) return; //you cannot set reward points for the anonymous customer record
            _rewardPoints = value;
        }
    }

    [JsonIgnore]
    public virtual bool IsAnonymous => Phone == AnonymousCustomerId;

    public override string ToString()
    {
        return IsAnonymous  
            ? "Anonymous Customer - No Reward Points"
            : $"{FirstName} {LastName}, {Phone}, Reward Points: {RewardPoints}";
    }
}