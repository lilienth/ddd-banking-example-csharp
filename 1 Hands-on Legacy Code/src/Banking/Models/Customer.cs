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

    public String getFirstName() {
        return firstName;
    }

    public String getFamilyName() {
        return familyName;
    }

    public DateOnly getDateOfBirth() {
        return dateOfBirth;
    }

    public int getCustomerNumber() {
        return customerNumber;
    }

    public List<Account> getAccountList() {
        return accountList;
    }

    public List<Credit> getCreditList() {
        return creditList;
    }

}
