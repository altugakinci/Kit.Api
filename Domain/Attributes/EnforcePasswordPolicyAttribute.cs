using Domain.ErrorMessages;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Domain.Attributes;

public class EnforcePasswordPolicyAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        return value is string && Regex.IsMatch(value as string, "/^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$/") ?
            ValidationResult.Success:
            new ValidationResult(AuthenticationMessages.Register_PasswordPolicy);
    }
}
