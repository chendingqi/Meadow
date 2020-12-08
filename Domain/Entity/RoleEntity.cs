using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    /// <summary>
    /// 系统角色
    /// </summary>
    public class RoleEntity : BaseEntity
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        [MaxLength(64)]
        public string Name { get; set; }
    }
}
