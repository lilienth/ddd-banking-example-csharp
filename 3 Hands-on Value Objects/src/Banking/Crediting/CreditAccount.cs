using Banking.Accounting;
using Banking.SharedKernel;

namespace Banking.Crediting;

public class CreditAccount : Account
{
    private Credit credit;

    public CreditAccount(int accountNumber, Credit credit)
        : base(accountNumber, credit.GetCustomer())
    {
        this.SetBalance(Amount.Of(0.0f).Subtract(credit.GetAmountOfCredit()));
        this.credit = credit;
    }

    public Credit getCredit()
    {
        return credit;
    }

}
