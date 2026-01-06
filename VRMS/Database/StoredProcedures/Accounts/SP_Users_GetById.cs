namespace VRMS.Database.StoredProcedures.Accounts;

public static class SP_Users_GetById
{
    public static string Sql() => """
                                  CREATE PROCEDURE sp_users_get_by_id (
                                      IN p_user_id INT
                                  )
                                  BEGIN
                                      SELECT
                                          id,
                                          username,
                                          password_hash,
                                          role,
                                          is_active
                                      FROM users
                                      WHERE id = p_user_id;
                                  END;
                                  """;
}