using Banking.SharedKernel;

namespace Banking.Accounting;

public class AccountTest
{
    [Fact]
    public void TestAccountConstruction()
    {
        Customer accountowner = new Customer("Carola", "Lilienthal", new DateOnly(1967, 9, 11), 11);
        Account account = new Account(10, accountowner);

        Assert.Equal(10, account.GetAccountnumber());
        Assert.Equal(0, account.GetBalance().Value());
        Assert.Equal(accountowner, account.GetAccountowner());
    }

    [Fact]
    void TestBalanceAccount()
    {
        Customer accountowner = new Customer("Carola", "Lilienthal", new DateOnly(1967, 9, 11), 11);
        Account account = new Account(10, accountowner);
        Assert.Equal(0, account.GetBalance().Value());
        account.SetBalance(Amount.Of(100));
        Assert.Equal(100, account.GetBalance().Value());

    }
}
