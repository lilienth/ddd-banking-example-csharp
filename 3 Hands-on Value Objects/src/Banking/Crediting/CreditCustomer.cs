namespace Banking.Crediting;

using Banking.SharedKernel;

public class CreditCustomer {
	private String firstName;
	private String familyName;
	private DateOnly dateOfBirth;
	private CustomerNumber customerNumber;
	private IList<CreditAccount> accountList;
	private IList<Credit> creditList;

	public CreditCustomer(CustomerNumber customerNumber, String firstName, String familyName, DateOnly dateOfBirth) {
		// ‚super();
		this.firstName = firstName;
		this.familyName = familyName;
		this.dateOfBirth = dateOfBirth;
		this.customerNumber = customerNumber;
		accountList = new List<CreditAccount>();
		creditList = new List<Credit>();
	}

	public String getFirstName()
    {
		return firstName;
	}

	public String getFamilyName()
    {
		return familyName;
	}

	public DateOnly getDateOfBirth()
    {
		return dateOfBirth;
	}

	public CustomerNumber getCustomerNumber()
    {
		return customerNumber;
	}

	public IList<CreditAccount> getAccountList()
    {
		return accountList;
	}

	public IList<Credit> getCreditList()
    {
		return creditList;
	}

}
