namespace VRMS.Database.SPImplementations.Accounts;

public static class SP_Users_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_users_create;
                                  
                                  CREATE PROCEDURE sp_users_create (
                                      IN p_username VARCHAR(50),
                                      IN p_full_name VARCHAR(100),
                                      IN p_email VARCHAR(150),
                                      IN p_phone VARCHAR(30),
                                      IN p_password_hash VARCHAR(255),
                                      IN p_role VARCHAR(50),
                                      IN p_status VARCHAR(20),
                                      IN p_photo_path VARCHAR(255)
                                  )
                                  BEGIN
                                      INSERT INTO users (
                                          username,
                                          full_name,
                                          email,
                                          phone,
                                          password_hash,
                                          role,
                                          account_status,
                                          photo_path
                                      )
                                      VALUES (
                                          p_username,
                                          p_full_name,
                                          p_email,
                                          p_phone,
                                          p_password_hash,
                                          p_role,
                                          p_status,
                                          p_photo_path
                                      );
                                  
                                      SELECT LAST_INSERT_ID() AS id;
                                  END;
                                  
                                  
                                  
                                  """;
}