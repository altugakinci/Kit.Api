namespace Domain.ErrorMessages;

public class AuthenticationMessages
{
    public const string Register_PasswordsDontMatch = "Passwords don't match.";
    public const string Register_PasswordPolicy = "Password must be at least 8 characters, include at least 1 lowercase, 1 uppercase, 1 symbol and 1 digit.";

    public const string EmailConfirmation_Success = "Email has been confirmed.";
    public const string EmailConfirmation_Failed= "Invalid confirmation code.";

    public const string ForgotPassword_ConfirmationSent = "A confirmation email sent for persisting your new password";
    public const string ForgotPassword_PasswordsDontMatch = "Passwords don't match.";
    public const string ForgotPassword_LinkExpired = "This link is expired.";
    public const string ForgotPassword_NoRequestFound = "No pending forgot password request found for this email.";
}
