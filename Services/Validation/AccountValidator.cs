using System;

namespace VRMS.Services.Validation;

public static class AccountValidator
{
    // =====================================================
    // USERNAME
    // =====================================================

    public static void ValidateUsername(string username)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new InvalidOperationException(
                "Username is required.");

        if (username.Length < 4)
            throw new InvalidOperationException(
                "Username must be at least 4 characters.");

        if (username.Length > 50)
            throw new InvalidOperationException(
                "Username cannot exceed 50 characters.");
    }

    // =====================================================
    // PASSWORD
    // =====================================================

    public static void ValidatePassword(
        string password,
        string confirmPassword)
    {
        if (string.IsNullOrWhiteSpace(password))
            throw new InvalidOperationException(
                "Password is required.");

        if (password.Length < 6)
            throw new InvalidOperationException(
                "Password must be at least 6 characters.");

        if (password != confirmPassword)
            throw new InvalidOperationException(
                "Passwords do not match.");
    }
}