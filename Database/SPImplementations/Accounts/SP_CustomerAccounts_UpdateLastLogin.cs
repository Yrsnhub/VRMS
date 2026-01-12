namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_CustomerAccounts_UpdateLastLogin
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_customer_accounts_update_last_login;

                                  CREATE PROCEDURE sp_customer_accounts_update_last_login (
                                      IN p_account_id INT
                                  )
                                  BEGIN
                                      UPDATE customer_accounts
                                      SET last_login_at = NOW(),
                                          must_change_password = 0
                                      WHERE id = p_account_id;
                                  END;
                                  """;
}