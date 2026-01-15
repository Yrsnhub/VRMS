namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_Users_GetByUsername
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_users_get_by_username;
                                  
                                  CREATE PROCEDURE sp_users_get_by_username (
                                      IN p_username VARCHAR(50)
                                  )
                                  BEGIN
                                      SELECT
                                          id,
                                          username,
                                          full_name,
                                          email,
                                          phone,
                                          password_hash,
                                          role,
                                          account_status,
                                          photo_path
                                      FROM users
                                      WHERE username = p_username
                                        AND account_status != 'Removed';
                                  
                                  END;
                                  """;
}