namespace Banking.SharedKernel;

class CreditNumberTest {

    [Fact]
    void Of()
    {
        CreditNumber creditNumber = CreditNumber.of(5);
        Assert.NotNull(creditNumber);
        Assert.Equal(5, creditNumber.creditNumberValue());
    }

    [Fact]
    void OfInvalid()
    {
        Assert.Throws<ArgumentException>(() => CreditNumber.Of(0));
        Assert.Throws<ArgumentException>(() => CreditNumber.Of(-1));
    }

    [Fact]
    void TestEquals()
    {
        CreditNumber creditNumber1 = CreditNumber.of(1);
        CreditNumber creditNumber2 = CreditNumber.of(1);
        CreditNumber creditNumber3 = CreditNumber.of(2);

        Assert.True(creditNumber1.equals(creditNumber1));
        Assert.Equal(creditNumber1, creditNumber2);
        Assert.Equal(creditNumber2, creditNumber1);
        Assert.NotEqual(creditNumber1, creditNumber3);
    }
}
