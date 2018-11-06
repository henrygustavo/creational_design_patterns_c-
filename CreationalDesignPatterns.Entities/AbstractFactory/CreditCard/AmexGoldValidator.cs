namespace CreationalDesignPatterns.Entities.AbstractFactory.CreditCard
{
	public class AmexGoldValidator : Validator
	{

		public virtual bool IsValid(CreditCard creditCard)
		{

			return false;
		}

	}

}