namespace CreationalDesignPatterns.Entities.AbstractFactory.CreditCard
{
	public abstract class CreditCard
	{

		protected internal int cardNumberLength;

		protected internal int cscNumber;

		public virtual int CardNumberLength
		{
			get
			{
				return cardNumberLength;
			}
			set
			{
				this.cardNumberLength = value;
			}
		}


		public virtual int CscNumber
		{
			get
			{
				return cscNumber;
			}
			set
			{
				this.cscNumber = value;
			}
		}


	}
}