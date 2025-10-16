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
		super();
		this.firstName = firstName;
		this.familyName = familyName;
		this.dateOfBirth = dateOfBirth;
		this.customerNumber = customerNumber;
		accountList = new List<>();
		creditList = new List<>();
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

	public List<CreditAccount> getAccountList()
    {
		return accountList;
	}

	public List<Credit> getCreditList()
    {
		return creditList;
	}

}
