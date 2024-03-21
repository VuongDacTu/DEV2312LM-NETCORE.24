using BT4._1;


Acount acount = new Acount(193.0);
acount.GetBalance();
CheckAccount check = new CheckAccount(acount.Balance, 23.3);
SavingAccount save = new SavingAccount(acount.Balance, 2.3);
check.Deposit(7.0);
check.GetBalance();
save.GetInterest();
save.GetBalance();