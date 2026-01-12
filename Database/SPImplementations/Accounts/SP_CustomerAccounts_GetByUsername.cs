namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_CustomerAccounts_GetByUsername
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_customer_accounts_get_by_username;

                                  CREATE PROCEDURE sp_customer_accounts_get_by_username (
                                      IN p_username VARCHAR(50)
                                  )
                                  BEGIN
                                      SELECT *
                                      FROM customer_accounts
                                      WHERE username = p_username
                                        AND is_enabled = 1;
                                  END;
                                  """;
}