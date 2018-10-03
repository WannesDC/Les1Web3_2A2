using Banking2A2.Models.Domain;
using System;
using System.Collections.Generic;

namespace Banking2A2
{
	class Program
	{
		static void Main(string[] args)
		{

			BankAccount myBA = new BankAccount("123-12312312-99");

			Console.WriteLine($"Account {myBA.AccountNumber} created...");
			Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
			//Console.WriteLine($"Withdrawcost is {BankAccount._withdrawCost} Euro");
			BankAccount myOBA = new BankAccount("123-12312312-99",50);

			Console.WriteLine($"Account {myOBA.AccountNumber} created...");
			Console.WriteLine($"Balance is currently {myOBA.Balance} Euro");


			myBA.Deposit(1000);
			Console.WriteLine(myBA);
			myBA.Withdraw(200);
			Console.WriteLine(myBA);
			myBA.Withdraw(100);
			Console.WriteLine(myBA);

			var transactions = myBA.Transactions;
			foreach (var item in transactions)
			{
				Console.WriteLine($"{item.DateOfTransaction} -- {item.Amount} -- {item.TransactionType}");
			}

			var mySA = new SavingsAccount("123-12312312-88", 0.01M);
			mySA.Deposit(1000);
			mySA.AddInterest();
			mySA.Withdraw(20);
			Console.WriteLine("SavingsAccount: ");
			foreach (var item in mySA.Transactions)
			{
				Console.WriteLine($"{item.DateOfTransaction} -- {item.Amount} -- {item.TransactionType}");
			}
			Console.ReadKey();

		}
	}
}
