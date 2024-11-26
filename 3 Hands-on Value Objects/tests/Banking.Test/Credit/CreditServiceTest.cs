using Banking.Accounting;
using Banking.SharedKernel;

namespace Banking.Crediting;

public class CreditServiceTest
{
    [Fact]
    void TestCSCreation()
    {
        AccountManagementService ams = AccountManagementServiceTest.PrepareTestData();
        CreditService cs = new CreditService(ams);

        int creditNumber = cs.ApplyForCredit(Amount.Of(1000), ams.GetCustomerList()[0]);
        Credit credit = cs.GetCredit(creditNumber);
        Assert.Equal(1000, credit.GetAmountOfCredit().Value());
        Assert.True(credit.GetStatus() == Credit.Status.Applied);

        CreditAccount creditAccount = cs.GrantCredit(creditNumber);
        Assert.Equal(credit, creditAccount.getCredit());
        Assert.True(credit.GetStatus() == Credit.Status.Granted);
        Assert.True(credit.GetAccount() == creditAccount);
        Assert.Contains(creditAccount, ams.GetAccountList());
        Assert.Contains(creditAccount.GetAccountowner(), ams.GetCustomerList());
        Assert.Equal(11, ams.GetAccountList().Count);
        Assert.Equal(credit, creditAccount.getCredit());

        Credit credit2 = cs.GetCreditFromAccountNumber(creditAccount.GetAccountnumber());
        Assert.Equal(credit, credit2);
    }

    [Fact]
    void TestCreditProcess()
    {
        AccountManagementService ams = AccountManagementServiceTest.PrepareTestData();
        CreditService cs = new CreditService(ams);

        int creditNumber = cs.ApplyForCredit(Amount.Of(1000), ams.GetCustomerList()[0]);
        Credit credit = cs.GetCredit(creditNumber);

        CreditAccount creditAccount = cs.GrantCredit(creditNumber);
        Assert.Equal(credit, creditAccount.getCredit());
        Assert.True(credit.GetStatus() == Credit.Status.Granted);
        Assert.True(credit.GetAccount() == creditAccount);
        Assert.Equal(-1000, creditAccount.GetBalance().Value());
        Assert.Equal(11, ams.GetAccountList().Count);

        cs.MakePaymentForCredit(creditNumber, Amount.Of(100));
        Assert.Equal(-900, creditAccount.GetBalance().Value());
        Assert.Equal(1000, credit.GetAmountOfCredit().Value());
    }

}
