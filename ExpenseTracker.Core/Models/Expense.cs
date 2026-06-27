namespace ExpenseTracker.Core.Models;

public class Expense
{
    public Guid Id {get; set;}
    public decimal Amount {get; set;}
    public string Description { get; set; } = string.Empty;
    public DateTime Date {get; set;}
    public Guid CategoryId {get; set;}
    public Guid UserId {get; set;}
}