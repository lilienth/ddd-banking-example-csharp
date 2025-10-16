using Banking.Accounting;
using Banking.SharedKernel;

namespace Banking.Crediting;

public class CreditCustomerTest {

	[Fact]
	void testCustomerConstruction() {

		CreditCustomer customer = new CreditCustomer(new CustomerNumber(1), "Carola", "Lilienthal", new DateOnly(1967, 9, 11));
		Assert.Equal("Carola", customer.getFirstName());
		Assert.Equal("Lilienthal", customer.getFamilyName());
		Assert.Equal(new DateOnly(1967, 9, 11), customer.getDateOfBirth());
		Assert.NotNull(customer.getCustomerNumber());
		Assert.NotNull(customer.getAccountList());
	}

}
