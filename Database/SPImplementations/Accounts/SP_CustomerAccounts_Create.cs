namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_CustomerAccounts_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_customer_accounts_create;

                                  CREATE PROCEDURE sp_customer_accounts_create (
                                      IN p_customer_id INT,
                                      IN p_username VARCHAR(50),
                                      IN p_password_hash VARCHAR(255),
                                      IN p_created_by_agent_id INT
                                  )
                                  BEGIN
                                      INSERT INTO customer_accounts (
                                          customer_id,
                                          username,
                                          password_hash,
                                          created_by_agent_id
                                      )
                                      VALUES (
                                          p_customer_id,
                                          p_username,
                                          p_password_hash,
                                          p_created_by_agent_id
                                      );

                                      SELECT LAST_INSERT_ID() AS id;
                                  END;
                                  """;
}