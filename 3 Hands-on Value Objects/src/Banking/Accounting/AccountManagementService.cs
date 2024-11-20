using Banking.Crediting;
using Banking.SharedKernel;

namespace Banking.Accounting;

public class AccountManagementService
{
    private IDictionary<int, Customer> customerList = new Dictionary<int, Customer>();
	private int customerNumberCounter = 0;
	private IDictionary<int, Account> accountList = new Dictionary<int, Account>();
	private int accountNumberCounter = 0;

	public AccountManagementService()
    {
	}

	public Customer NewCustomer(String firstName, String familyName, DateOnly dateOfBirth)
    {
		Customer customer = new Customer(firstName, familyName, dateOfBirth, customerNumberCounter++);
		customerList.Add(customer.GetCustomerNumber(), customer);
		return customer;
	}

	public Account NewAccount(Amount balance, Customer customer)
    {
		Account account = new Account(accountNumberCounter++, customer);
		account.SetBalance(balance);
		accountList.Add(account.GetAccountnumber(), account);
		customer.GetAccountList().Add(account);
		return account;
	}

	public CreditAccount NewCreditAccount(Credit credit)
    {
		CreditAccount account = new CreditAccount(accountNumberCounter++, credit);
		accountList.Add(account.GetAccountnumber(), account);
		credit.GetCustomer().GetAccountList().Add(account);
		return account;
	}

	public IList<Account> GetAccountList()
    {
		return new List<Account>(accountList.Values);
	}

	public IList<Customer> GetCustomerList()
    {
		return new List<Customer>(customerList.Values);
	}

	public void TransferMoney(Amount amount, int debitorAccountNumber, int creditorAccountNumber)
    {
		Amount balance = accountList[debitorAccountNumber].GetBalance();
		balance = balance.Subtract(amount);
		accountList[debitorAccountNumber].SetBalance(balance);

		balance = accountList[creditorAccountNumber].GetBalance();
		balance = balance.Add(amount);
		accountList[creditorAccountNumber].SetBalance(balance);
	}

	public ICollection<int> GetAccountNumberList()
    {
        return accountList.Keys;
	}

	public Account GetAccount(int accountNumber) {
		return accountList[accountNumber];
	}

	public Customer GetCustomer(int accountNumber)
    {
		return accountList[accountNumber].GetAccountowner();
	}

}
