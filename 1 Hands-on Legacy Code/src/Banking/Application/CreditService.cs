using Banking.Models;

namespace Banking.Application;

public class CreditService
{
    private AccountManagementService accountManagementService = null;

    private int creditNumberCounter = 0;
    private IDictionary<int, Credit> creditList = new Dictionary<int, Credit>();

    public CreditService(AccountManagementService accountManagementService)
    {
        this.accountManagementService = accountManagementService;
    }

    public int ApplyForCredit(float amount, Customer customer)
    {
        int creditNumber = creditNumberCounter++;
        Credit credit = new Credit(creditNumber, customer, amount);
        creditList.Add(creditNumber, credit);

        return creditNumber;
    }

    public CreditAccount GrantCredit(int creditNumber)
    {
        Credit credit = this.GetCredit(creditNumber);
        credit.SetStatus(Credit.Status.Granted);
        CreditAccount newCreditAccount = accountManagementService.NewCreditAccount(credit);
        credit.SetAccount(newCreditAccount);
        return newCreditAccount;
    }

    public Credit GetCredit(int creditNumber)
    {
        return creditList[creditNumber];
    }

    public Credit GetCreditFromAccountNumber(int accountNumber)
    {
        CreditAccount account = (CreditAccount) accountManagementService.GetAccount(accountNumber);
        return creditList[account.getCredit().GetCreditNumber()];
    }

    public void MakePaymentForCredit(int creditNumber, float amount)
    {
        Credit credit = creditList[creditNumber];
        CreditAccount creditAccount = credit.GetAccount();
        float balance = creditAccount.GetBalance();
        balance = balance + amount;
        creditAccount.SetBalance(balance);
    }

    public void MakePaymentForCreditAccount(int accountNumber, float amount)
    {
        Account account = accountManagementService.GetAccount(accountNumber);
        float balance = account.GetBalance();
        balance = balance + amount;
        account.SetBalance(balance);
    }

}
