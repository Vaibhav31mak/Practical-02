using System.Diagnostics.CodeAnalysis;

namespace CustomerApplication;
#region
[method: SetsRequiredMembers]
// Used primary constructors for readibility
public class CustomerAccount(long accountNo, string customerName)
{
    // This property won't change because the BankName would be same so its static
    public static string? BankName { get; set; }
    public required long CustomerAccountNo { get; set; } = accountNo;
    public required string CustomerName { get; set; } = customerName;
#endregion
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