using System;

class RandomTestCaseGenerator
{
	static Random random = new Random();
	const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

	static string GenerateRandomCustomerName()
	{
		int nameLength = random.Next(2, 65);
		char[] name = new char[nameLength];

		for (int i = 0; i < nameLength; i++)
		{
			name[i] = allowedChars[random.Next(0, allowedChars.Length)];
		}

		return new string(name);
	}

	static string GenerateRandomAccountNumber(bool isNegative = false)
	{
		int accountNumber;
		if (isNegative)
		{
			accountNumber = random.Next(1, 100000); // Generate a negative account number
		}
		else
		{
			accountNumber = random.Next(100000, 1000000); // Generate a positive account number
		}
		return accountNumber.ToString("D6"); // Ensure 6 digits with leading zeros if necessary
	}

	static decimal GenerateRandomLoanAmount(bool isNegative = false)
	{
		decimal loanAmount;
		if (isNegative)
		{
			// Generate a negative loan amount less than £500
			loanAmount = (decimal)random.Next(1, 500) * 1;
		}
		else
		{
			// Generate a positive loan amount within the range of £500 to £9000
			loanAmount = (decimal)random.Next(500, 9001);
		}
		return loanAmount;
	}

	static int GenerateRandomLoanTerm(bool isNegative = false)
	{
		int loanTerm;
		if (isNegative)
		{
			loanTerm = random.Next(31, 60); // Generate a negative loan term
		}
		else
		{
			loanTerm = random.Next(1, 31); // Generate a positive loan term
		}
		return loanTerm;
	}

	static decimal GenerateRandomMonthlyRepayment(bool isNegative = false)
	{
		decimal monthlyRepayment;
		if (isNegative)
		{
			monthlyRepayment = (decimal)random.Next(1, 10); // Generate a negative monthly repayment
		}
		else
		{
			monthlyRepayment = (decimal)random.Next(10, 1001); // Generate a positive monthly repayment
		}
		return monthlyRepayment;
	}

	static void Main(string[] args)
	{
		Console.WriteLine("Positive Test Cases:");
		for (int i = 0; i < 5; i++)
		{
			string customerName = GenerateRandomCustomerName();
			string accountNumber = GenerateRandomAccountNumber();
			decimal loanAmount = GenerateRandomLoanAmount();
			int loanTerm = GenerateRandomLoanTerm();
			decimal monthlyRepayment = GenerateRandomMonthlyRepayment();

			Console.WriteLine($"Test Case {i + 1} (Positive):");
			Console.WriteLine("Customer Name: " + customerName);
			Console.WriteLine("Account Number: " + accountNumber);
			Console.WriteLine("Loan Amount Request: £" + loanAmount);
			Console.WriteLine("Term of Loan: " + loanTerm + " years");
			Console.WriteLine("Monthly Repayment: £" + monthlyRepayment);
			Console.WriteLine("------------------------------------------------------------------------------------------");
			Console.WriteLine();
		}
		Console.WriteLine("#########################################################################################");
		Console.WriteLine("Negative Test Cases:");
		for (int i = 0; i < 5; i++)
		{
			string customerName = GenerateRandomCustomerName();
			string accountNumber = GenerateRandomAccountNumber(true);
			decimal loanAmount = GenerateRandomLoanAmount(true);
			int loanTerm = GenerateRandomLoanTerm(true);
			decimal monthlyRepayment = GenerateRandomMonthlyRepayment(true);

			Console.WriteLine($"Test Case {i + 1} (Negative):");
			Console.WriteLine("Customer Name: " + customerName);
			Console.WriteLine("Account Number: " + accountNumber);
			Console.WriteLine("Loan Amount Request: £" + loanAmount);
			Console.WriteLine("Term of Loan: " + loanTerm + " years");
			Console.WriteLine("Monthly Repayment: £" + monthlyRepayment);
			Console.WriteLine("------------------------------------------------------------------------------------------");
			Console.WriteLine();
		}
	}
}
