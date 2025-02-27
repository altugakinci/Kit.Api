using Domain.Attributes;
using System.ComponentModel.DataAnnotations;

namespace AccountService.Requests.Authentication;

public class LoginRequest
{
    [Required(AllowEmptyStrings = false), EmailAddress]
    public string Email { get; set; }

    [Required(AllowEmptyStrings = false)]
    public string Password { get; set; }
}
