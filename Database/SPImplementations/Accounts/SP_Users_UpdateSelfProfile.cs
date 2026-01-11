namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_Users_UpdateSelfProfile
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_users_update_self_profile;

                                  CREATE PROCEDURE sp_users_update_self_profile (
                                      IN p_user_id INT,
                                      IN p_full_name VARCHAR(100),
                                      IN p_email VARCHAR(150),
                                      IN p_phone VARCHAR(30)
                                  )
                                  BEGIN
                                      UPDATE users
                                      SET
                                          full_name = p_full_name,
                                          email = p_email,
                                          phone = p_phone
                                      WHERE id = p_user_id
                                        AND is_active = TRUE;
                                  END;
                                  """;
}