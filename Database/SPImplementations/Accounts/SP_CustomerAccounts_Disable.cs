namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_CustomerAccounts_Disable
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_customer_accounts_disable;

                                  CREATE PROCEDURE sp_customer_accounts_disable (
                                      IN p_account_id INT
                                  )
                                  BEGIN
                                      UPDATE customer_accounts
                                      SET is_enabled = 0
                                      WHERE id = p_account_id;
                                  END;
                                  """;
}