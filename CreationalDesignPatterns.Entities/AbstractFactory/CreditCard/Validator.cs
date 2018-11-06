namespace CreationalDesignPatterns.Entities.AbstractFactory.CreditCard
{
	public interface Validator
	{
		bool IsValid(CreditCard creditCard);
	}

}