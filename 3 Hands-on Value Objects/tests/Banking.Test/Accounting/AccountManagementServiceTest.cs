using Banking.Crediting;
using Banking.SharedKernel;

namespace Banking.Accounting;

public class AccountManagementServiceTest
{

	public static AccountManagementService PrepareTestData() {
		AccountManagementService ams = new AccountManagementService();
		Customer customer = ams.NewCustomer("Carola", "Lilienthal", new DateOnly(1967, 9, 11));
		ams.NewAccount(Amount.Of(1000), customer);
		ams.NewAccount(Amount.Of(5000), customer);
		ams.NewAccount(Amount.Of(2000), customer);

		customer = ams.NewCustomer("Hans", "Lilienthal", new DateOnly(1968, 9, 11));
		ams.NewAccount(Amount.Of(2000), customer);
		ams.NewAccount(Amount.Of(5000), customer);

		customer = ams.NewCustomer("Dieter", "Lilienthal", new DateOnly(1969, 9, 11));
		ams.NewAccount(Amount.Of(3000), customer);
		ams.NewAccount(Amount.Of(5000), customer);

		customer = ams.NewCustomer("Franz", "Lilienthal", new DateOnly(1964, 9, 11));
		ams.NewAccount(Amount.Of(4000), customer);
		ams.NewAccount(Amount.Of(5000), customer);

		customer = ams.NewCustomer("Carsten", "Lilienthal", new DateOnly(1965, 9, 11));
		ams.NewAccount(Amount.Of(5000), customer);

		return ams;
	}

	[Fact]
	void TestAmsCreation() {
		AccountManagementService ams = AccountManagementServiceTest.PrepareTestData();
		Assert.NotNull(ams.GetAccountList());
		Assert.NotNull(ams.GetCustomerList());
		Assert.Equal(5, ams.GetCustomerList().Count);
		Assert.Equal(10, ams.GetAccountList().Count);
		int counter = 0;
		foreach (Customer customer in ams.GetCustomerList()) {
			counter = counter + customer.GetAccountList().Count;
		}
		Assert.Equal(10, counter);
	}

	[Fact]
	void TestAmsNewCustomerNewAccount() {
		AccountManagementService ams = AccountManagementServiceTest.PrepareTestData();

		Customer newCustomer = ams.NewCustomer("Tea", "Ginster", new DateOnly(1950, 12, 2));
		Assert.Contains(newCustomer, ams.GetCustomerList());

		Account newAccount = ams.NewAccount(Amount.Of(2000), newCustomer);
		Assert.Contains(newAccount, ams.GetAccountList());
		Assert.Equal(newAccount, ams.GetAccount(newAccount.GetAccountnumber()));
		Assert.Equal(newCustomer, ams.GetAccount(newAccount.GetAccountnumber()).GetAccountowner());
		Assert.Contains(newAccount, newCustomer.GetAccountList());
		Assert.Equal(11, ams.GetAccountList().Count);

		Credit credit = new Credit(1000, newCustomer, Amount.Of(10));
		CreditAccount newCreditAccount = ams.NewCreditAccount(credit);
		Assert.Contains(newCreditAccount, ams.GetAccountList());
		Assert.Equal(newCreditAccount, ams.GetAccount(newCreditAccount.GetAccountnumber()));
		Assert.Equal(12, ams.GetAccountList().Count);

		Assert.Contains(newAccount.GetAccountnumber(), ams.GetAccountNumberList());
		Assert.Contains(newCreditAccount.GetAccountnumber(), ams.GetAccountNumberList());
		Assert.Contains(newCreditAccount, newCustomer.GetAccountList());

	}

	[Fact]
	void TestAmsTransferMoney() {
		AccountManagementService ams = AccountManagementServiceTest.PrepareTestData();

		ICollection<int> accountNumbers = ams.GetAccountNumberList();
        using var enumerator = accountNumbers.GetEnumerator();
        enumerator.MoveNext();
		int debitorAccountNumber = enumerator.Current;
        enumerator.MoveNext();
		int creditorAccountNumber = enumerator.Current;
		Amount debitorSaldo = ams.GetAccount(debitorAccountNumber).GetBalance();
		Amount creditorSaldo = ams.GetAccount(creditorAccountNumber).GetBalance();
		ams.TransferMoney(Amount.Of(100), debitorAccountNumber, creditorAccountNumber);
		Assert.Equal(debitorSaldo.Value() - 100, ams.GetAccount(debitorAccountNumber).GetBalance().Value());
		Assert.Equal(creditorSaldo.Value() + 100, ams.GetAccount(creditorAccountNumber).GetBalance().Value());

	}
}
