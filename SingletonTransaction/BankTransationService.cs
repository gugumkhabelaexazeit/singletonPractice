using System;

namespace SingletonTransaction;

public class BankTransactionService
{
  public void Deposit(string accountId, decimal amount)
  {
    TransactionLogger.Instance.Log($"Deposit{amount:c}into account {accountId}.");
  }

  public void Withdraw(string accountId, decimal amount)
  {
    TransactionLogger.Instance.Log($"Withdraw{amount:c}into account {accountId}.");
  }

  public void Transfer(string fromAccount, string toAccount, decimal amount)
  {
    TransactionLogger.Instance.Log($"Transferred {amount:C} from {fromAccount} to {toAccount}.");
  }

}
