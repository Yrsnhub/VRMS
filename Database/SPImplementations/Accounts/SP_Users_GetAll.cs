namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_Users_GetAll
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_users_get_all;
                                  
                                  CREATE PROCEDURE sp_users_get_all ()
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
                                      WHERE account_status != 'Removed'
                                      ORDER BY username;
                                  END;
                                  
                                  """;
}