namespace Banking.SharedKernel;

class CreditNumberFactoryTest {

    [Fact]
    void IsKnownCreditNumber()
    {
        CreditNumberFactory objectUnderTest = new CreditNumberFactory();

        CreditNumber creditNumber = objectUnderTest.newCreditNumber();
        Assert.NotNull(creditNumber);
        Assert.True(objectUnderTest.isKnownCreditNumber(creditNumber));

        int maxCreditNumber = creditNumber.creditNumberValue();
        Assert.False(objectUnderTest.isKnownCreditNumber(CreditNumber.of(maxCreditNumber + 1)));
    }
}
