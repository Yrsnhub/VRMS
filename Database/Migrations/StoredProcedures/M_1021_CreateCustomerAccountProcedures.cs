using VRMS.Database.SPImplementations.Accounts;

namespace VRMS.Database.Migrations.StoredProcedures;

public static class M_1021_CreateCustomerAccountProcedures
{
    public static string Create() => $"""
                                      {SP_CustomerAccounts_Create.Sql()}
                                      {SP_CustomerAccounts_GetByCustomerId.Sql()}
                                      {SP_CustomerAccounts_GetByUsername.Sql()}
                                      {SP_CustomerAccounts_Disable.Sql()}
                                      {SP_CustomerAccounts_UpdatePassword.Sql()}
                                      {SP_CustomerAccounts_UpdateLastLogin.Sql()}
                                      """;

    public static string Drop() => """
                                   DROP PROCEDURE IF EXISTS sp_customer_accounts_create;
                                   DROP PROCEDURE IF EXISTS sp_customer_accounts_get_by_customer_id;
                                   DROP PROCEDURE IF EXISTS sp_customer_accounts_get_by_username;
                                   DROP PROCEDURE IF EXISTS sp_customer_accounts_disable;
                                   DROP PROCEDURE IF EXISTS sp_customer_accounts_update_password;
                                   DROP PROCEDURE IF EXISTS sp_customer_accounts_update_last_login;
                                   """;
}