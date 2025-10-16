using Banking.Crediting;

namespace Banking.Accounting;

public class Customer
{
    private String firstName;
    private String familyName;
    private DateOnly dateOfBirth;
    private int customerNumber;
    private IList<Account> accountList;
    private IList<Credit> creditList;

    public Customer(String firstName, String familyName, DateOnly dateOfBirth, int customerNumber)
    {
        this.firstName = firstName;
        this.familyName = familyName;
        this.dateOfBirth = dateOfBirth;
        this.customerNumber = customerNumber;
        accountList = new List<Account>();
        creditList = new List<Credit>();
    }

    public String GetFirstName()
    {
        return firstName;
    }

    public String GetFamilyName()
    {
        return familyName;
    }

    public DateOnly GetDateOfBirth()
    {
        return dateOfBirth;
    }

    public int GetCustomerNumber()
    {
        return customerNumber;
    }

    public IList<Account> GetAccountList()
    {
        return accountList;
    }

    public IList<Credit> GetCreditList()
    {
        return creditList;
    }

}
