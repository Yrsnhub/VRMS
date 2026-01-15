using VRMS.Database.DBHelpers.EnumHelper;
using VRMS.Enums;

namespace VRMS.Database.Migrations.Tables;

public static class M_0002_CreateUsersTable
{
    public static string Create() => $"""
                                       CREATE TABLE IF NOT EXISTS users (
                                           id INT AUTO_INCREMENT PRIMARY KEY,

                                           username VARCHAR(50) NOT NULL UNIQUE,
                                           full_name VARCHAR(100) NULL,
                                           email VARCHAR(150) NULL,
                                           phone VARCHAR(30) NULL,

                                           password_hash VARCHAR(255) NOT NULL,
                                           role {Tbl.ToEnum<UserRole>()} NOT NULL,
                                           account_status {Tbl.ToEnum<AccountStatus>()} NOT NULL DEFAULT 'Active',
                                           photo_path VARCHAR(255) NULL
                                       ) ENGINE=InnoDB;
                                       """;

    public static string Drop() => """
                                   DROP TABLE IF EXISTS users;
                                   """;
}