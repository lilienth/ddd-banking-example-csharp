namespace Banking.SharedKernel;

public class CreditNumberFactoryTest {

    [Fact]
    void IsKnownCreditNumber()
    {
        CreditNumberFactory objectUnderTest = new CreditNumberFactory();

        CreditNumber creditNumber = objectUnderTest.NewCreditNumber();
        Assert.NotNull(creditNumber);
        Assert.True(objectUnderTest.IsKnownCreditNumber(creditNumber));

        int maxCreditNumber = creditNumber.CreditNumberValue;
        Assert.False(objectUnderTest.IsKnownCreditNumber(CreditNumber.Of(maxCreditNumber + 1)));
    }
}
