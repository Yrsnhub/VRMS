namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_Users_UpdateProfile
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_users_update_profile;

                                  CREATE PROCEDURE sp_users_update_profile (
                                      IN p_user_id INT,
                                      IN p_username VARCHAR(50),
                                      IN p_role VARCHAR(50),
                                      IN p_status VARCHAR(20)
                                  )
                                  BEGIN
                                      UPDATE users
                                      SET
                                          username = p_username,
                                          role = p_role,
                                          account_status = p_status
                                      WHERE id = p_user_id;
                                  END;
                                  """;
}