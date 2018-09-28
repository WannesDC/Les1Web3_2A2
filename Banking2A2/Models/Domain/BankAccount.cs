using System;
using System.Collections.Generic;
using System.Text;

namespace Banking2A2.Models.Domain
{
	class BankAccount
	{
		//Ctrl+K+S to surround with region!
		//private string _accountnumber;
		#region field
		private decimal _balance;
		#endregion

		//public const decimal WithdrawCost = 0.10M;
		//public static readonly decimal _withdrawCost = 0.10M;
		#region properties
		public decimal Balance
		{
			get
			{
				return _balance;
			}
			private set
			{
				if (value < 0)
					throw new ArgumentException("Balance cannot be negative.");

				_balance = value;
			}
		}

		public string AccountNumber { get; private set; }
		#endregion

		#region methods

		
		public void Deposit(decimal amount)
		{
			if(amount < 0)
				throw new ArgumentException("Deposits cannot be negative.");
			Balance += amount;
		}

		public void Withdraw(decimal amount)
		{
			if (amount < 0)
				throw new ArgumentException("Withdrawals cannot be negative.");
			//Ctrl+D: Copy line below

			Balance -= amount;
		}
		#endregion

		#region Constructors
		public BankAccount(string accountNumber)
		{
			AccountNumber = accountNumber;
		}

		public BankAccount(string accountNumber, decimal balance):this(accountNumber)
		{
			Balance = balance;
			//_withdrawCost = 0.10M;
		}
		#endregion
	}
}
