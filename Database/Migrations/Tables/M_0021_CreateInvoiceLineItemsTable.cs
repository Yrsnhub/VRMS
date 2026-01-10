namespace VRMS.Database.Migrations.Tables;

public static class M_0021_CreateInvoiceLineItemsTable
{
    public static string Create() => """
                                     CREATE TABLE IF NOT EXISTS invoice_line_items (
                                         id INT AUTO_INCREMENT PRIMARY KEY,
                                         invoice_id INT NOT NULL,
                                         description VARCHAR(255) NOT NULL,
                                         amount DECIMAL(10,2) NOT NULL,

                                         CONSTRAINT fk_invoice_items_invoice
                                             FOREIGN KEY (invoice_id)
                                             REFERENCES invoices(id)
                                             ON DELETE CASCADE
                                     ) ENGINE=InnoDB;
                                     """;

    public static string Drop() => """
                                   DROP TABLE IF EXISTS invoice_line_items;
                                   """;
}