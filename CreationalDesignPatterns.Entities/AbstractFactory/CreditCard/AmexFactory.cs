namespace CreationalDesignPatterns.Entities.AbstractFactory.CreditCard
{
	public class AmexFactory : CreditCardFactory
	{

		public override CreditCard GetCreditCard(CardType cardType)
		{

			switch (cardType)
			{
				case CardType.GOLD:
					return new AmexGoldCreditCard();

				case CardType.PLATINUM:
					return new AmexPlatinumCreditCard();

				default:
					break;
			}

			return null;
		}

		public override Validator GetValidator(CardType cardType)
		{

			switch (cardType)
			{
				case CardType.GOLD:

					return new AmexGoldValidator();

				case CardType.PLATINUM:

					return new AmexPlatinumValidator();

			}

			return null;
		}
	}
}