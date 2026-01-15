namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_Users_GetById
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_users_get_by_id;
                                  
                                  CREATE PROCEDURE sp_users_get_by_id (
                                      IN p_user_id INT
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
                                      WHERE id = p_user_id
                                        AND account_status != 'Removed';
                                  END;
                                  
                                  """;
}