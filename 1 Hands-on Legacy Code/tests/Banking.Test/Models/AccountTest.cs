namespace Banking.Models;

public class AccountTest
{
    [Fact]
    public void TestAccountConstruction()
    {
        Customer accountowner = new Customer("Carola", "Lilienthal", new DateOnly(1967, 9, 11), 11);
        Account account = new Account(10, accountowner);

        Assert.Equal(10, account.getAccountnumber());
        Assert.Equal(0, account.getBalance());
        Assert.Equal(accountowner, account.getAccountowner());
    }
}
