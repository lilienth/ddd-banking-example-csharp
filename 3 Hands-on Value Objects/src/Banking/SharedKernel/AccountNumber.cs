namespace Banking.SharedKernel;

/**
 * ValueObject, representing a syntactically valid account number
 *
 * <p>Implemented as a class with:</p>
 * <ul>
 *     <li>isValid method to check for validity</li>
 *     <li>private constructor and  a factory method "of" to control object creation and decouple external and internal representation</li>
 *     <li>equals/hashCode based on the internal int value</li>
 * </ul>
 *
 * @see CustomerNumber for an alternative way of implementing value objects
 * @see CreditNumber for an alternative way of implementing value objects
 */
public class AccountNumber
{

	public static bool IsValid(int accountNumberValue) {
		return accountNumberValue > 0;
	}

	public static AccountNumber Of(int accountNumberValue) {
		return new AccountNumber(accountNumberValue);
	}

	private int accountNumberValue;

	private AccountNumber(int accountNumberValue) {
		this.accountNumberValue = accountNumberValue;
	}

	public int ValueInt() {
		return this.accountNumberValue;
	}

}
