namespace Banking.SharedKernel;

class AmountTest {

	@Test
	void testCreation() {
		Assert.True(Amount.IsValidAmount(100));
		Assert.True(Amount.IsValidAmount(-100));
		Assert.True(Amount.IsValidAmount(0));
		Assert.True(Amount.IsValidAmount(1));
		Assert.True(Amount.IsValidAmount(-1));

		Amount amount = Amount.Of(10);
		Assert.NotNull(amount);
		Assert.Equal(10, amount.value());
	}

	@Test
	void testAdd() {
		Amount amount1 = Amount.of(10);
		Amount amount2 = Amount.of(5);
		Assert.False(amount1.equals(amount2));

		Amount amount3 = amount1.add(amount2);

		Assert.Equal(15, amount3.Value());
	}

	@Test
	void testSubtract() {
		Amount amount1 = Amount.Of(10);
		Amount amount2 = Amount.Of(5);

		Amount amount3 = amount1.Subtract(amount2);

		Assert.Equal(5, amount3.Value());
		Assert.True(amount2.equals(amount3));
	}

}
