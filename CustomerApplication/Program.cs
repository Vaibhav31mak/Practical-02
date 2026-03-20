using CustomerApplication;

Console.WriteLine("Summary:-\nMethod: PrintInfo()\nPrints customer account details including bank name, account number, and customer name.\nReturn Type: void");
CustomerAccount.BankName = "State Bank Of India";
CustomerAccount account = new CustomerAccount(123456789, "Vaibhav");

account.PrintInfo();
Console.ReadKey();