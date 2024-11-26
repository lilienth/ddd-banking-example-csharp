namespace Banking.SharedKernel;

/**
 * ValueObject, representing a syntactically valid amount
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
public class Amount
{

	public static bool IsValidAmount(Amount amount) {
		// All float values are considered valid
		return true;
	}

	public static Amount Of(float amount) {
		return new Amount(amount);
	}

	private float amount;

	private Amount(float amount) {
		this.amount = amount;
	}

	public Amount Add(Amount secondAmount) {
		return new Amount(this.amount + secondAmount.amount);
	}

	public Amount Subtract(Amount secondAmount) {
		return new Amount(this.amount - secondAmount.amount);
	}

	public float Value() {
		return this.amount;
	}

}
