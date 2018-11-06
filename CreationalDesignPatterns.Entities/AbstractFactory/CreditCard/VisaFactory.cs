namespace CreationalDesignPatterns.Entities.AbstractFactory.CreditCard
{
	public class VisaFactory : CreditCardFactory
	{

		public override CreditCard GetCreditCard(CardType cardType)
		{
			switch (cardType)
			{
				case CardType.GOLD:

					return new VisaGoldCreditCard();

				case CardType.PLATINUM:

					return new VisaBlackCreditCard();

			}

			return null;
		}

		public override Validator GetValidator(CardType cardType)
		{
			return new VisaValidator();
		}

	}

}