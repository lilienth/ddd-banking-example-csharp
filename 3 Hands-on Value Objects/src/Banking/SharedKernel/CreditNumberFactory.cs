namespace Banking.SharedKernel;

using static System.Diagnostics.Debug;

/**
 * Factory to create {@link CreditNumber}s.
 */
public class CreditNumberFactory
{
    /**
     * Normally this would be backed by some kind of persistence store
     */
    private static int numberCounter = 0;

    public CreditNumber NewCreditNumber()
    {
        int nextFreeNumber = Interlocked.Increment(ref numberCounter);
        return CreditNumber.Of(nextFreeNumber);
    }

    public bool IsKnownCreditNumber(CreditNumber creditNumber)
    {
        Assert(creditNumber != null);
        return creditNumber.Value() <= numberCounter;
    }
}
