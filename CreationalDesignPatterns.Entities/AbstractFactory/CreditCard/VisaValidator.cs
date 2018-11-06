namespace CreationalDesignPatterns.Entities.AbstractFactory.CreditCard
{
	public class VisaValidator : Validator
	{
		public virtual bool IsValid(CreditCard creditCard)
		{
			return false;
		}

	}
}