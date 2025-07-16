using System;
 namespace SingletonTransaction
{
  class Program
  {
    static void Main(string[] args)
    {

      var bankService = new BankTransactionService();
      bankService.Deposit("Account123", 500);
      bankService.Withdraw("Account123", 200);
      bankService.Transfer("Account123", "Account456", 150);

      Console.WriteLine("\nPress any key to exit...");

      Console.ReadKey();

    }
  }
}
