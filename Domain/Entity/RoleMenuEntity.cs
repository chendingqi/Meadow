using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    /// <summary>
    /// 角色菜单
    /// </summary>
    public class RoleMenuEntity : BaseEntity
    {
        /// <summary>
        /// 角色标识
        /// </summary>
        public Guid RoleId { get; set; }
        /// <summary>
        /// 菜单标识
        /// </summary>
        public Guid MenuId { get; set; }
        /// <summary>
        /// 操作权限
        /// </summary>
        [MaxLength(64)]
        public string Operation { get; set; }
    }
}
