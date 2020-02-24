using System;
namespace atm_program
{
	class Atm_Trancsation
	{
		static void Main(String[] args)
		{
			int amount = 1000,withdraw,deposit,pin=0;
            Console.WriteLine("***WELCOME TO EQUAL BANK ATM SERVICE***\n");
			//read PIN
			Console.WriteLine("Enter the four digit pin number");
			pin = int.Parse(Console.ReadLine());
            
			
			if(pin >= 4)
			{	
				Console.WriteLine("1.To check balance");
				Console.WriteLine("2.To withdraw money");
				Console.WriteLine("3.To deposit Money");
				Console.WriteLine("Enter your choice");
				int choice = int.Parse(Console.ReadLine());

				switch(choice)
				{
					case 1:
						Console.WriteLine("The current balance in your account is " + amount);
						Console.WriteLine("**THANK YOU FOR USING EQUAL BANK ATM SERVICE**");
					break;
					
					case 2:
					Console.WriteLine("Enter the amount to withdraw");
					{
						withdraw = int.Parse(Console.ReadLine());
						if(amount >= withdraw)
						{
							if(withdraw % 100 == 0)
							{
								Console.WriteLine("Please collect your cash " + withdraw);
								amount = amount - withdraw;
								Console.WriteLine("The current balance is now " + amount);
								Console.WriteLine("**THANK YOU FOR USING EQUAL BANK ATM SERVICE**");
							}
							else
								Console.WriteLine("Please enter the amount to withdraw in the multiples of 100");
						}
						else
						Console.WriteLine("Your account does not have sufficient balance");
					}

					break;

					case 3:
					Console.WriteLine("Enter the amount to be deposit");
					deposit = int.Parse(Console.ReadLine());
					amount = amount + deposit;
					Console.WriteLine("The current balance in the account is " + amount);
					Console.WriteLine("Your Amount has been deposited successfully");
					Console.WriteLine("**THANK YOU FOR USING EQUAL BANK ATM SERVICE**");
					break;
					
					
					default:
					Console.WriteLine("Please select correct option");
					break;
				}
			}
			else
				Console.WriteLine("Entered Pin is wrong");
		}
	}
}
