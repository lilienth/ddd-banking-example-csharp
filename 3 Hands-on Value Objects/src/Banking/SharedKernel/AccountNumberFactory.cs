namespace Banking.SharedKernel;

using static System.Diagnostics.Debug;

/**
 * Factory to create {@link AccountNumber}s.
 */
public class AccountNumberFactory
{
    /**
     * Normally this would be backed by some kind of persistence store
     */
    private static int numberCounter;

    public AccountNumber NewAccountNumber()
    {
        int nextFreeNumber = Interlocked.Increment(ref numberCounter);
        return AccountNumber.Of(nextFreeNumber);
    }

    public bool IsKnownAccountNumber(AccountNumber accountNumber)
    {
        Assert(accountNumber != null);
        return accountNumber.ValueInt() <= numberCounter;
    }
}
