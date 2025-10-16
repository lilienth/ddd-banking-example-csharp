namespace Banking.Crediting;

public class CreditCustomer {
	private String firstName;
	private String familyName;
	private DateOnly dateOfBirth;
	private int customerNumber;
	private IList<CreditAccount> accountList;
	private IList<Credit> creditList;

	public CreditCustomer(String firstName, String familyName, DateOnly dateOfBirth, int customerNumber)
    {
		super();
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

	public int getCustomerNumber()
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
