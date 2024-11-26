namespace Banking.Models;

public class CreditTest
{
    [Fact]
    void TestCreditConstruction()
    {
        Customer customer = new Customer("Carola", "Lilienthal", new DateOnly(1967, 9, 11), 11);
        Credit credit = new Credit(12, customer, 1000);
        Assert.Equal(1000, credit.GetAmountOfCredit());
        Assert.Equal(customer, credit.GetCustomer());
        Assert.Equal(12, credit.GetCreditNumber());
        Assert.Contains(credit, customer.GetCreditList());
    }

}
