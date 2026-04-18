namespace CommonDataUtils.Core.Entities;
public class SoftDeleteEntity : AuditableEntity
{
    public bool IsDeleted { get; set; }
}