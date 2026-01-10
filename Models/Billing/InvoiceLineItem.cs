namespace VRMS.Models.Billing;

public class InvoiceLineItem
{
    public int Id { get; set; }
    public int InvoiceId { get; set; }

    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
}