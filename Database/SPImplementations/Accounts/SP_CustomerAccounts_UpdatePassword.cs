namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_CustomerAccounts_UpdatePassword
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_customer_accounts_update_password;

                                  CREATE PROCEDURE sp_customer_accounts_update_password (
                                      IN p_account_id INT,
                                      IN p_password_hash VARCHAR(255)
                                  )
                                  BEGIN
                                      UPDATE customer_accounts
                                      SET password_hash = p_password_hash,
                                          must_change_password = 1
                                      WHERE id = p_account_id;
                                  END;
                                  """;
}