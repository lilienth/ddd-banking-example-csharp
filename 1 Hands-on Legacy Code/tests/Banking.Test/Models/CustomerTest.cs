namespace Banking.Models;

public class CustomerTest
{
    [Fact]
    void TestCustomerConstruction()
    {
        Customer customer = new Customer("Carola", "Lilienthal", new DateOnly(1967, 9, 11), 11);
        Assert.Equal("Carola", customer.getFirstName());
        Assert.Equal("Lilienthal", customer.getFamilyName());
        Assert.Equal(new DateOnly(1967, 9, 11), customer.getDateOfBirth());
        Assert.Equal(11, customer.getCustomerNumber());
        Assert.NotNull(customer.getAccountList());
        Assert.NotNull(customer.getCreditList());
    }
}
