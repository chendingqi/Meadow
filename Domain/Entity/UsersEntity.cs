using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    /// <summary>
    /// 系统用户
    /// </summary>
    public class UsersEntity : BaseEntity
    {
        /// <summary>
        /// 昵称
        /// </summary>
        [MaxLength(64)]
        public string NickName { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        [MaxLength(64)]
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [MaxLength(64)]
        public string Password { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        [MaxLength(256)]
        public string HeadImage { get; set; }
    }
}
