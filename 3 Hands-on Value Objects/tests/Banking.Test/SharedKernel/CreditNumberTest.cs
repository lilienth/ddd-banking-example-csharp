namespace Banking.SharedKernel;

public class CreditNumberTest {

    [Fact]
    void Of()
    {
        CreditNumber creditNumber = CreditNumber.Of(5);
        Assert.NotNull(creditNumber);
        Assert.Equal(5, creditNumber.CreditNumberValue);
    }

    [Fact]
    void OfInvalid()
    {
        Assert.ThrowsAny<Exception>(() => CreditNumber.Of(0));
        Assert.ThrowsAny<Exception>(() => CreditNumber.Of(-1));
    }

    [Fact]
    void TestEquals()
    {
        CreditNumber creditNumber1 = CreditNumber.Of(1);
        CreditNumber creditNumber2 = CreditNumber.Of(1);
        CreditNumber creditNumber3 = CreditNumber.Of(2);

        Assert.True(creditNumber1.Equals(creditNumber1));
        Assert.Equal(creditNumber1, creditNumber2);
        Assert.Equal(creditNumber2, creditNumber1);
        Assert.NotEqual(creditNumber1, creditNumber3);
    }
}
