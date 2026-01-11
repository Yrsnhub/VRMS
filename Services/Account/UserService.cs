using VRMS.Enums;
using VRMS.Helpers.Security;
using VRMS.Models.Accounts;
using VRMS.Repositories.Accounts;

namespace VRMS.Services.Account;

/// <summary>
/// Provides business logic for user authentication,
/// account lifecycle management, and profile maintenance.
/// 
/// This service acts as the single authority for:
/// - Authentication & password validation
/// - User creation and deactivation
/// - Password changes
/// - Profile and role updates
/// </summary>
public class UserService
{
    /// <summary>
    /// Repository responsible for direct user data access.
    /// </summary>
    private readonly UserRepository _userRepo;

    /// <summary>
    /// Initializes the user service with its required repository.
    /// </summary>
    /// <param name="userRepo">User repository instance</param>
    public UserService(UserRepository userRepo)
    {
        _userRepo = userRepo;
    }

    // ----------------------------
    // AUTHENTICATION
    // ----------------------------

    /// <summary>
    /// Authenticates a user using username and plaintext password.
    /// </summary>
    /// <param name="username">Username used for login</param>
    /// <param name="plainPassword">Plaintext password provided by the user</param>
    /// <returns>
    /// The authenticated <see cref="User"/> object if credentials are valid
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the password is invalid
    /// </exception>
    public User Authenticate(
        string username,
        string plainPassword)
    {
        var user =
            _userRepo.GetForAuthentication(username);

        if (!Password.Verify(
                plainPassword,
                user.PasswordHash))
            throw new InvalidOperationException(
                "Invalid password.");

        return user;
    }

    // ----------------------------
    // CREATE USER
    // ----------------------------

    /// <summary>
    /// Creates a new user account.
    /// </summary>
    /// <param name="username">Unique username</param>
    /// <param name="plainPassword">Initial plaintext password</param>
    /// <param name="role">Assigned user role</param>
    /// <param name="isActive">Indicates whether the account is active</param>
    /// <returns>
    /// The newly created user's ID
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the username is empty or invalid
    /// </exception>
    public int CreateUser(
        string username,
        string plainPassword,
        UserRole role,
        bool isActive = true)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new InvalidOperationException(
                "Username cannot be empty.");

        var hash = Password.Hash(plainPassword);

        return _userRepo.Create(
            username,
            hash,
            role,
            isActive);
    }

    // ----------------------------
    // LOOKUPS
    // ----------------------------

    /// <summary>
    /// Retrieves a user by their unique identifier.
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <returns>The matching <see cref="User"/> record</returns>
    public User GetById(int userId)
        => _userRepo.GetById(userId);

    /// <summary>
    /// Retrieves a user by their username.
    /// </summary>
    /// <param name="username">Username</param>
    /// <returns>The matching <see cref="User"/> record</returns>
    public User GetByUsername(string username)
        => _userRepo.GetByUsername(username);

    // ----------------------------
    // DEACTIVATE
    // ----------------------------

    /// <summary>
    /// Deactivates a user account without deleting it.
    /// </summary>
    /// <param name="userId">User ID</param>
    public void Deactivate(int userId)
        => _userRepo.Deactivate(userId);

    // ----------------------------
    // PASSWORD MANAGEMENT
    // ----------------------------

    /// <summary>
    /// Changes a user's password after verifying the current password.
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="currentPlainPassword">Current plaintext password</param>
    /// <param name="newPlainPassword">New plaintext password</param>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the current password does not match
    /// </exception>
    public void ChangePassword(
        int userId,
        string currentPlainPassword,
        string newPlainPassword)
    {
        var user = _userRepo.GetById(userId);

        if (!Password.Verify(
                currentPlainPassword,
                user.PasswordHash))
            throw new InvalidOperationException(
                "Current password is incorrect.");

        var newHash =
            Password.Hash(newPlainPassword);

        _userRepo.UpdatePassword(
            userId,
            newHash);
    }

    // ----------------------------
    // PROFILE MANAGEMENT
    // ----------------------------

    /// <summary>
    /// Updates a user's profile details including username, role, and activation state.
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="username">Updated username</param>
    /// <param name="role">Updated user role</param>
    /// <param name="isActive">Updated activation status</param>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the username is empty or invalid
    /// </exception>
    public void UpdateUserProfile(
        int userId,
        string username,
        UserRole role,
        bool isActive)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new InvalidOperationException(
                "Username cannot be empty.");

        _userRepo.UpdateProfile(
            userId,
            username,
            role,
            isActive);
    }
}
