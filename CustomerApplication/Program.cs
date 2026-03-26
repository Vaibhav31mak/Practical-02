using CustomerApplication;

CustomerAccount.BankName = "State Bank Of India";
CustomerAccount account = new CustomerAccount(123456789, "Vaibhav");

account.PrintInfo();
Console.ReadKey();
