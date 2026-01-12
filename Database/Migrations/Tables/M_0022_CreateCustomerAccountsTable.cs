using VRMS.Database.DBHelpers.EnumHelper;

namespace VRMS.Database.Migrations.Tables;

public static class M_0022_CreateCustomerAccountsTable
{
    public static string Create() => $"""
                                      CREATE TABLE IF NOT EXISTS customer_accounts (
                                          id INT AUTO_INCREMENT PRIMARY KEY,

                                          customer_id INT NOT NULL,
                                          username VARCHAR(50) NOT NULL,
                                          password_hash VARCHAR(255) NOT NULL,

                                          is_enabled BOOLEAN NOT NULL DEFAULT 1,
                                          must_change_password BOOLEAN NOT NULL DEFAULT 1,

                                          last_login_at DATETIME NULL,

                                          created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                                          created_by_agent_id INT NOT NULL,

                                          -- one account per customer
                                          CONSTRAINT uq_customer_accounts_customer
                                              UNIQUE (customer_id),

                                          -- usernames must be unique
                                          CONSTRAINT uq_customer_accounts_username
                                              UNIQUE (username),

                                          CONSTRAINT fk_customer_accounts_customer
                                              FOREIGN KEY (customer_id)
                                              REFERENCES customers(id)
                                              ON DELETE RESTRICT,

                                          CONSTRAINT fk_customer_accounts_agent
                                              FOREIGN KEY (created_by_agent_id)
                                              REFERENCES users(id)
                                              ON DELETE RESTRICT
                                      ) ENGINE=InnoDB;
                                      """;

    public static string Drop() => """
                                   DROP TABLE IF EXISTS customer_accounts;
                                   """;
}