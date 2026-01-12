namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_CustomerAccounts_GetByCustomerId
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_customer_accounts_get_by_customer_id;

                                  CREATE PROCEDURE sp_customer_accounts_get_by_customer_id (
                                      IN p_customer_id INT
                                  )
                                  BEGIN
                                      SELECT *
                                      FROM customer_accounts
                                      WHERE customer_id = p_customer_id;
                                  END;
                                  """;
}