using BankEncapsulation;


var bankAccount = new BankAccount();

Console.Write("Deposit all of your money: ");
var userInput = double.Parse(Console.ReadLine());
bankAccount.Deposit(userInput);

Console.Write($"your total is {bankAccount.GetBalance()}");