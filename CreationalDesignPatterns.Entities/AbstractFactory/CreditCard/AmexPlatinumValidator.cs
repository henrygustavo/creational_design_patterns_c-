namespace CreationalDesignPatterns.Entities.AbstractFactory.CreditCard
{
	public class AmexPlatinumValidator : Validator
	{

		public virtual bool IsValid(CreditCard creditCard)
		{

			return false;
		}

	}

}