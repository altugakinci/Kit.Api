namespace Domain.Entities.RelationEntities;

public class UserMailConfirmation : BaseEntity
{
    public string Email { get; set; }
    public string Code { get; set; }
    public DateTime ExpiresAtUtc { get; set; }
}
