namespace Banking.SharedKernel;

using static System.Diagnostics.Debug;

/**
 * Factory to create {@link CustomerNumber}s.
 */
public class CustomerNumberFactory
{

    /**
     * Normally this would be backed by some kind of persistence store
     */
    private static int numberCounter = 0;

    public CustomerNumber NewCustomerNumber()
    {
        int nextFreeNumber = Interlocked.Increment(ref numberCounter);
        return new CustomerNumber(nextFreeNumber);
    }

    public bool IsKnownCustomerNumber(CustomerNumber CustomerNumber)
    {
        Assert(CustomerNumber != null);
        return CustomerNumber.CustomerNumberValue <= numberCounter;
    }
}
