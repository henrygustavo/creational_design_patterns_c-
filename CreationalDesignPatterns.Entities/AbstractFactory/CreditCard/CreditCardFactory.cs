namespace CreationalDesignPatterns.Entities.AbstractFactory.CreditCard
{
	//AbstractFactory
	public abstract class CreditCardFactory
	{

		public static CreditCardFactory GetCreditCardFactory(int creditScore)
		{

			if (creditScore > 650)
			{
				return new AmexFactory();
			}
			else
			{
				return new VisaFactory();
			}
		}

		public abstract CreditCard GetCreditCard(CardType cardType);

		public abstract Validator GetValidator(CardType cardType);
	}
}