using System;
namespace Fifth_Semester
{
	public class BankAccount
	{
		private string _accountNumber;
		private string _accountHolderName;
		private string _bankName;
		private int _balance;
		

		public void OpenAccount(string num,string name,string bank ) {
			_accountNumber = num;
			_accountHolderName = name;
			_bankName = bank;
			_balance = 0;
			Console.WriteLine("Account Created! Holder Name:" + _accountHolderName);


        }
		public void Deposit (int amount)
		{
			_balance += amount;
			Console.WriteLine("Deposited amount:" + amount);
		}
		public void Withdraw(int amount)
		{
		if(amount<= _balance) {
				_balance -= amount;
				Console.WriteLine("Withdraw Amount: " + amount);
			}
			else
			{
				Console.WriteLine("No  sufficient amount");
			}

				}
		public void Checkbalance() {
			Console.WriteLine("Account holder:" + _accountHolderName);
			Console.WriteLine("Balance: " + _balance);
		}
		
	}
}

