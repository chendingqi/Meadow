using System;

namespace Domain.Entity
{
    /// <summary>
    /// 用户角色
    /// </summary>
    public class RoleUsersEntity : BaseEntity
    {
        /// <summary>
        /// 用户标识
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 角色标识
        /// </summary>
        public Guid RoleId { get; set; }
    }
}
