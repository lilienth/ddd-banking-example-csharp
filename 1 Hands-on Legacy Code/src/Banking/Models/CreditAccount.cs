namespace Banking.Models;

public class CreditAccount : Account
{
    private Credit credit;

    public CreditAccount(int accountNumber, Credit credit)
        : base(accountNumber, credit.GetCustomer())
    {
        this.SetBalance(-(credit.GetAmountOfCredit()));
        this.credit = credit;
    }

    public Credit getCredit()
    {
        return credit;
    }

}
