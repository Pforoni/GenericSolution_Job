using System;

namespace Generic.Entities
{
    public class UserRole : IEntityBase
    {
        public Guid ID { get; set; }
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}