using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    /// <summary>
    /// 系统菜单
    /// </summary>
    public class MenuEntity : BaseEntity
    {
        public string _icon = "FileDocumentBoxOutline";
        /// <summary>
        /// 名称
        /// </summary>
        [MaxLength(32)]
        public string Name { get; set; }
        /// <summary>
        /// 父级标识
        /// </summary>
        public Guid? ParentId { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [MaxLength(32)]
        public string Type { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
        [MaxLength(256)]
        public string Link { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        [MaxLength(32)]
        public string Icon { get => _icon; set => _icon = value; }
    }
}
