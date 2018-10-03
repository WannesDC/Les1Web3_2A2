using System;
using System.Collections.Generic;

namespace Banking2A2.Models.Domain
{
	public class BankAccount : IBankAccount
	{
		//Ctrl+K+S to surround with region!
		//private string _accountnumber;

		#region field

		private decimal _balance;
		private ICollection<Transaction> _transactions;

		#endregion field

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

		public IEnumerable<Transaction> Transactions
		{
			get
			{
				return _transactions;
			}
		}
		#endregion properties

		#region methods

		public virtual void Deposit(decimal amount)
		{
			if (amount < 0)
				throw new ArgumentException("Deposits cannot be negative.");
			Balance += amount;
			_transactions.Add(new Transaction(amount, TransactionType.Deposit));
		}

		public virtual void Withdraw(decimal amount)
		{
			if (amount < 0)
				throw new ArgumentException("Withdrawals cannot be negative.");
			//Ctrl+D: Copy line below

			Balance -= amount;

			_transactions.Add(new Transaction(amount, TransactionType.Withdraw));

		}

		public override string ToString()
		{
			return $"{AccountNumber} -- {Balance}";
		}

		public override bool Equals(object obj)
		{
			BankAccount ba = obj as BankAccount;
			// BankAccount ba = (BankAccount)obj; --> werpt mogelijks een exception
			if(ba == null)
			{
				return false;
			}

			return AccountNumber == ba.AccountNumber;
		}

		public override int GetHashCode()
		{
			return AccountNumber.GetHashCode();
		}

		#endregion methods

		#region Constructors

		public BankAccount(string accountNumber)
		{
			AccountNumber = accountNumber;
			_transactions = new List<Transaction>();
		}

		public BankAccount(string accountNumber, decimal balance ) : this(accountNumber)
		{
			Balance = balance;
			//_withdrawCost = 0.10M;
			
			
		}

		#endregion Constructors
	}
}