namespace AccountService.Requests.Authentication;

public class ConfirmEmailRequest
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmationCode { get; set; }
}
