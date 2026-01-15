namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_Users_UpdateStatus
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_users_update_status;

                                  CREATE PROCEDURE sp_users_update_status (
                                      IN p_id INT,
                                      IN p_status VARCHAR(20)
                                  )
                                  BEGIN
                                      UPDATE users
                                      SET account_status = p_status
                                      WHERE id = p_id;
                                  END;
                                  """;
}