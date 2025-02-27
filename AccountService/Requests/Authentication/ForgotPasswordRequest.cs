namespace AccountService.Requests.Authentication;

public class ForgotPasswordRequest
{
    public string Email { get; set; }
    public string NewPassword { get; set; }
    public string ReNewPassword { get; set; }
}
