using Banking.Accounting;
using Banking.SharedKernel;

namespace Banking.Crediting;

public class CreditService
{
    private AccountManagementService accountManagementService = null;

    private int creditNumberCounter = 0;
    private IDictionary<int, Credit> creditList = new Dictionary<int, Credit>();

    public CreditService(AccountManagementService accountManagementService)
    {
        this.accountManagementService = accountManagementService;
    }

    public int ApplyForCredit(Amount amount, Customer customer)
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

    public void MakePaymentForCredit(int creditNumber, Amount amount)
    {
        Credit credit = creditList[creditNumber];
        CreditAccount creditAccount = credit.GetAccount();
        Amount balance = creditAccount.GetBalance();
        balance = balance.Add(amount);
        creditAccount.SetBalance(balance);
    }

    public void MakePaymentForCreditAccount(int accountNumber, Amount amount)
    {
        Account account = accountManagementService.GetAccount(accountNumber);
        Amount balance = account.GetBalance();
        balance = balance.Add(amount);
        account.SetBalance(balance);
    }

}
