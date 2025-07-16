using System;

namespace SingletonTransaction;

public class TransactionLogger // act as singleton  logger for Transaction
{
  private static TransactionLogger _instance; // hold one and only instance, that can't be directly accessed from outside and can be used across whole app 
  private static readonly object _lock = new object(); // ensure thread safety

  private TransactionLogger() { } // can't instantiate from outside this class main() 

  public static TransactionLogger Instance  // ensure a global access 
  {
    get
    {
      lock (_lock) // ensure  that two threads do not create two instance the same time 
      {
        if (_instance == null)
          _instance = new TransactionLogger();

        return _instance;
      }
    }
  }

  public void Log(string message)
  {
    Console.WriteLine($"[LOG - {DateTime.Now}]: {message}");
  }     

}
