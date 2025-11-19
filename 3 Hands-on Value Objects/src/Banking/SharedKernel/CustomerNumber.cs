namespace Banking.SharedKernel;

using static System.Diagnostics.Debug;

/**
 * ValueObject, representing a syntactically valid customer number
 *
 * <p>Implemented as a record with:</p>
 * <ul>
 *     <li>isValid method to check validity</li>
 *     <li>a public constructor directly coupled to the internal representation</li>
 *     <li>validation implemented in the compact constructor</li>
 *     <li>default method to access the internal representation</li>
 *     <li>equals/hashCode automatically based on the internal int value</li>
 * </ul>
 *
 * @param customerNumberValue internal value of the customer number
 * @see CreditNumber
 * @see AccountNumber
 */
public readonly record struct CustomerNumber(int CustomerNumberValue)
{
    public static CustomerNumber Of(int customerNumberValue)
    {
        Assert(IsValid(customerNumberValue));
        return new CustomerNumber(customerNumberValue);
    }

    public static bool IsValid(int customerNumberValue)
    {
        return customerNumberValue > 0;
    }
}
