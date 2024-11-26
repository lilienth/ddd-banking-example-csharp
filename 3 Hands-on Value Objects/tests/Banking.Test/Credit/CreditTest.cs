using Banking.Accounting;
using Banking.SharedKernel;

namespace Banking.Crediting;

public class CreditTest
{
    [Fact]
    void TestCreditConstruction()
    {
        Customer customer = new Customer("Carola", "Lilienthal", new DateOnly(1967, 9, 11), 11);
        Credit credit = new Credit(12, customer, Amount.Of(1000));
        Assert.Equal(1000, credit.GetAmountOfCredit().Value());
        Assert.Equal(customer, credit.GetCustomer());
        Assert.Equal(12, credit.GetCreditNumber());
        Assert.Contains(credit, customer.GetCreditList());
    }

}
