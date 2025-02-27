using Domain.Attributes;
using System.ComponentModel.DataAnnotations;

namespace AccountService.Requests.Authentication;

public class RegisterRequest
{
    [Required(AllowEmptyStrings = false), EmailAddress]
    public string Email { get; set; }
    
    [Required(AllowEmptyStrings = false), EnforcePasswordPolicy]
    public string Password { get; set; }

    [Required(AllowEmptyStrings = false)]
    public string RePassword { get; set; }
}
