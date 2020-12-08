using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    /// <summary>
    /// 实体基类
    /// </summary>
    public abstract class BaseEntity
    {
        public DateTime _createTime = DateTime.Now;
        public DateTime _updateTime = DateTime.Now;
        /// <summary>
        /// 标识
        /// </summary>
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// 创建用户标识
        /// </summary>
        public Guid? CreateId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get => _createTime; set => _createTime = value; }
        /// <summary>
        /// 更新用户标识
        /// </summary>
        public Guid? UpdateId { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get => _updateTime; set => _updateTime = value; }
    }
}
