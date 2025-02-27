using Domain.Enums;

namespace Domain.Entities.RelationEntities;

public class UserForgotPassword : BaseEntity
{
    public string Email { get; set; }
    public string NewPasswordHash { get; set; }
    public string Status { get; set; } = ForgotPasswordEmailStatus.Pending;
    public DateTime ExpiresAtUtc { get; set; }
}
