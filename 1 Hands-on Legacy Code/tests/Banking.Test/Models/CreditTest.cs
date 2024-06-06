namespace Banking.Models;

public class CreditTest
{
    [Fact]
    void TestCreditConstruction()
    {
        Customer customer = new Customer("Carola", "Lilienthal", new DateOnly(1967, 9, 11), 11);
        Credit credit = new Credit(12, customer, 1000);
        Assert.Equal(1000, credit.getAmountOfCredit());
        Assert.Equal(customer, credit.getCustomer());
        Assert.Equal(12, credit.getCreditNumber());
        Assert.Contains(credit, customer.getCreditList());
    }

}
