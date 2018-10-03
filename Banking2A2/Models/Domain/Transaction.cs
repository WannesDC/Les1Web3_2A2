using System;

namespace Banking2A2.Models.Domain
{
	public class Transaction
	{
		public decimal Amount { get; } = 0M;

		public TransactionType TransactionType { get; }

		public DateTime DateOfTransaction { get; }

		public bool IsWithdraw
		{
			get
			{
				return TransactionType == TransactionType.Withdraw;
			}
		}

		public bool IsDeposit
		{
			get
			{
				return TransactionType == TransactionType.Deposit;
			}
		}

		public Transaction(decimal amount, TransactionType transactionType)
		{
			Amount = amount;
			TransactionType = transactionType;
			DateOfTransaction = DateTime.Today;
		}
	}
}