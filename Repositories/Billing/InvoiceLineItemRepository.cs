using System.Data;
using VRMS.Database;
using VRMS.Models.Billing;

namespace VRMS.Repositories.Billing;

public class InvoiceLineItemRepository
{
    public void Create(
        int invoiceId,
        string description,
        decimal amount)
    {
        DB.Execute(
            "CALL sp_invoice_line_items_create(@iid,@desc,@amt);",
            ("@iid", invoiceId),
            ("@desc", description),
            ("@amt", amount)
        );
    }

    public List<InvoiceLineItem> GetByInvoice(
        int invoiceId)
    {
        var table = DB.Query(
            "CALL sp_invoice_line_items_get_by_invoice(@iid);",
            ("@iid", invoiceId)
        );

        var list = new List<InvoiceLineItem>();
        foreach (DataRow row in table.Rows)
        {
            list.Add(new InvoiceLineItem
            {
                Id = Convert.ToInt32(row["id"]),
                InvoiceId =
                    Convert.ToInt32(row["invoice_id"]),
                Description =
                    row["description"].ToString()!,
                Amount =
                    Convert.ToDecimal(row["amount"])
            });
        }

        return list;
    }
}