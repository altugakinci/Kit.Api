using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class User : BaseEntity
{
    [Required(AllowEmptyStrings = false), EmailAddress]
    public string Email { get; set; }

    [Required(AllowEmptyStrings = false), PasswordPropertyText]
    public string PasswordHash { get; set; }
}
