using System;
using System.Data;
using VRMS.Database;
using VRMS.Models.Accounts;

namespace VRMS.Repositories.Accounts;

public class CustomerAccountRepository
{
    // =====================================================
    // CREATE
    // =====================================================

    public int Create(
        int customerId,
        string username,
        string passwordHash,
        int createdByAgentId)
    {
        var table = DB.Query(
            "CALL sp_customer_accounts_create(@customerId,@username,@hash,@agentId);",
            ("@customerId", customerId),
            ("@username", username),
            ("@hash", passwordHash),
            ("@agentId", createdByAgentId)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException(
                "Failed to create customer account.");

        return Convert.ToInt32(table.Rows[0]["id"]);
    }

    // =====================================================
    // READ
    // =====================================================

    public CustomerAccount? GetByCustomerId(int customerId)
    {
        var table = DB.Query(
            "CALL sp_customer_accounts_get_by_customer_id(@customerId);",
            ("@customerId", customerId)
        );

        if (table.Rows.Count == 0)
            return null;

        return Map(table.Rows[0]);
    }

    public CustomerAccount? GetByUsername(string username)
    {
        var table = DB.Query(
            "CALL sp_customer_accounts_get_by_username(@username);",
            ("@username", username)
        );

        if (table.Rows.Count == 0)
            return null;

        return Map(table.Rows[0]);
    }

    // =====================================================
    // UPDATE
    // =====================================================

    public void Disable(int accountId)
    {
        DB.Execute(
            "CALL sp_customer_accounts_disable(@id);",
            ("@id", accountId)
        );
    }

    public void UpdatePassword(int accountId, string passwordHash)
    {
        DB.Execute(
            "CALL sp_customer_accounts_update_password(@id,@hash);",
            ("@id", accountId),
            ("@hash", passwordHash)
        );
    }

    public void UpdateLastLogin(int accountId)
    {
        DB.Execute(
            "CALL sp_customer_accounts_update_last_login(@id);",
            ("@id", accountId)
        );
    }

    // =====================================================
    // MAPPING
    // =====================================================

    private static CustomerAccount Map(DataRow row)
    {
        return new CustomerAccount
        {
            Id = Convert.ToInt32(row["id"]),
            CustomerId = Convert.ToInt32(row["customer_id"]),
            Username = row["username"].ToString()!,
            PasswordHash = row["password_hash"].ToString()!,
            IsEnabled = Convert.ToBoolean(row["is_enabled"]),
            MustChangePassword = Convert.ToBoolean(row["must_change_password"]),
            LastLoginAt =
                row["last_login_at"] == DBNull.Value
                    ? null
                    : Convert.ToDateTime(row["last_login_at"]),
            CreatedAt = Convert.ToDateTime(row["created_at"]),
            CreatedByAgentId = Convert.ToInt32(row["created_by_agent_id"])
        };
    }
}
