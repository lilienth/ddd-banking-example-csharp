namespace Banking.Models;

public class Customer
{
    private String firstName;
    private String familyName;
    private DateOnly dateOfBirth;
    private int customerNumber;
    private List<Account> accountList;
    private List<Credit> creditList;

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

    public List<Account> GetAccountList()
    {
        return accountList;
    }

    public List<Credit> GetCreditList()
    {
        return creditList;
    }

}
