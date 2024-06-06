namespace Banking.Models;

public class Credit
{
    private float amountOfCredit;
    private int creditNumber;
    private Status status;
    private Customer customer;
    private CreditAccount? account;

    public enum Status
    {
        applied, refused, granted, delayed, payed
    }

    public Credit(int creditNumber, Customer customer, float amountOfCredit)
    {
        this.amountOfCredit = amountOfCredit;
        this.creditNumber = creditNumber;
        this.customer = customer;
        this.customer.getCreditList().Add(this);
        this.status = Status.applied;
    }

    public float getAmountOfCredit() {
        return amountOfCredit;
    }

    public void setAmountOfCredit(float amountOfCredit) {
        this.amountOfCredit = amountOfCredit;
    }

    public Customer getCustomer() {
        return customer;
    }

    public int getCreditNumber() {
        return creditNumber;
    }

    public Status getStatus() {
        return status;
    }

    public void setStatus(Status status) {
        this.status = status;
    }

    public CreditAccount? getAccount() {
        return account;
    }

    public void setAccount(CreditAccount account) {
        this.account = account;
    }

}
