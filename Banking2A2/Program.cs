﻿using Banking2A2.Models.Domain;
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
			Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
			myBA.Withdraw(200);
			Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
			myBA.Withdraw(100);
			Console.WriteLine($"Balance is currently {myBA.Balance} Euro");

			IEnumerable<Transaction> transactions = myBA.Transactions;
			foreach (var item in transactions)
			{
				Console.WriteLine($"{item.DateOfTransaction} -- {item.Amount} -- {item.TransactionType}");
			}
			Console.ReadKey();
		}
	}
}
