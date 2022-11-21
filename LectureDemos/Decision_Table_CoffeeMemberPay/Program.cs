var transactions = new List<Transaction> {
    new (true, true, true),
    new (true, true, false),
    new (true, false, true),
    new (true, false, false),
    
    new(false, true),
    new(false, false)
};

Console.WriteLine(AsciiTableFormatter.Formatter.Format(transactions));

for (int transactionIdx = 0; transactionIdx < transactions.Count; transactionIdx++)
{
    var transaction = transactions[transactionIdx];
    Console.WriteLine($"TRANSACTION {transactionIdx + 1}");
    Console.WriteLine($"- {transaction}");

    if(transaction.IsMember) {
        if(transaction.PresentedValidCreditCard) {
            Console.WriteLine(" + Pay with credit");
            Console.WriteLine(" + Earn rewards");
        } else if (transaction.HasSufficientPoints) {
            Console.WriteLine(" + Pay with Points");
        } else {
            Console.WriteLine(" + DENIED");
        }
    } else {
        //anon
        if (transaction.PresentedValidCreditCard)
        {
            Console.WriteLine(" + Pay with credit");
        }
        else
        {
            Console.WriteLine(" + DENIED");
        }
    }
    Console.WriteLine();
}

public class Transaction {
	public Transaction(bool isMember, bool presentedValidCreditCard, bool hasSufficientPoints = false)
	{
		IsMember = isMember;
		PresentedValidCreditCard = presentedValidCreditCard;
		
		if(!IsMember && hasSufficientPoints) throw new InvalidOperationException("Points are only for members");
		HasSufficientPoints = hasSufficientPoints; 
	}
	public bool IsMember { get; init; }
	public bool PresentedValidCreditCard { get; init;}
	public bool HasSufficientPoints { get; init; }
	public string Description => ToString();


	public override string ToString()
	{
		return $"{(IsMember ? "Member" : "Anonymous")}, " +
			   $"{(PresentedValidCreditCard ? "Presented Valid Credit Card" : "No Card Presented")}, " +
			   $"{(HasSufficientPoints ? "Has Sufficient Points" : "Insufficient Points")}";
	}
}