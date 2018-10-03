namespace Banking2A2.Models.Domain
{
	public class SavingsAccount : BankAccount
	{
		private const decimal WithdrawCost = 0.1M;

		public decimal InterestRate { get; private set; }

		public SavingsAccount(string accountNumber, decimal interestRate):base(accountNumber)
		{
			InterestRate = interestRate;
		}

		public void AddInterest()
		{
			Deposit(Balance * InterestRate);

		
		}

		public override void Withdraw(decimal amount)
		{
			base.Withdraw(amount);
			base.Withdraw(WithdrawCost);
		}
	}
}