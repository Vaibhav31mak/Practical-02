using System.Diagnostics.CodeAnalysis;

namespace CustomerApplication;

public class CustomerAccount
{
    public static string BankName { get; set; }
    public required long CustomerAccountNo { get; set; }
    public required string CustomerName { get; set; }

    [SetsRequiredMembers]
    public CustomerAccount(long accountNo, string customerName)
    {
        CustomerAccountNo = accountNo;
        CustomerName = customerName ?? throw new ArgumentNullException(nameof(customerName));
    }

    /// <summary>
    /// Prints customer account details including bank name, account number, and customer name.
    /// Return Type: void
    /// </summary>
    public void PrintInfo()
    {
        Console.WriteLine("Customer Account Details:-");
        Console.WriteLine($"Bank Name: {BankName}");
        Console.WriteLine($"Account Number: {CustomerAccountNo}");
        Console.WriteLine($"Customer Name: {CustomerName}");
    }
}