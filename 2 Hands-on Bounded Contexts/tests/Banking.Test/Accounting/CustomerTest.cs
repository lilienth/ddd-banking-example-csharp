namespace Banking.Accounting;

public class CustomerTest
{
    [Fact]
    void TestCustomerConstruction()
    {
        Customer customer = new Customer("Carola", "Lilienthal", new DateOnly(1967, 9, 11), 11);
        Assert.Equal("Carola", customer.GetFirstName());
        Assert.Equal("Lilienthal", customer.GetFamilyName());
        Assert.Equal(new DateOnly(1967, 9, 11), customer.GetDateOfBirth());
        Assert.Equal(11, customer.GetCustomerNumber());
        Assert.NotNull(customer.GetAccountList());
        Assert.NotNull(customer.GetCreditList());
    }
}
