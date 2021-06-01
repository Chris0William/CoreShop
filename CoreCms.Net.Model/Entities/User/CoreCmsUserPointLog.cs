/***********************************************************************
 *            Project: CoreCms
 *        ProjectName: 核心内容管理系统                                
 *                Web: https://www.corecms.net                      
 *             Author: 大灰灰                                          
 *              Email: jianweie@163.com                                
 *         CreateTime: 2021/1/31 21:45:10
 *        Description: 暂无
 ***********************************************************************/

using System;
using System.ComponentModel.DataAnnotations;
using SqlSugar;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    ///     用户积分记录表
    /// </summary>
    public partial class CoreCmsUserPointLog
    {
        /// <summary>
        ///     ID
        /// </summary>
        [Display(Name = "ID")]
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        [Required(ErrorMessage = "请输入{0}")]
        public int id { get; set; }

        /// <summary>
        ///     用户ID
        /// </summary>
        [Display(Name = "用户ID")]
        [Required(ErrorMessage = "请输入{0}")]
        public int userId { get; set; }

        /// <summary>
        ///     类型
        /// </summary>
        [Display(Name = "类型")]
        [Required(ErrorMessage = "请输入{0}")]
        public int type { get; set; }

        /// <summary>
        ///     积分数量
        /// </summary>
        [Display(Name = "积分数量")]
        [Required(ErrorMessage = "请输入{0}")]
        public int num { get; set; }

        /// <summary>
        ///     积分余额
        /// </summary>
        [Display(Name = "积分余额")]
        [Required(ErrorMessage = "请输入{0}")]
        public int balance { get; set; }

        /// <summary>
        ///     备注
        /// </summary>
        [Display(Name = "备注")]
        [StringLength(255, ErrorMessage = "{0}不能超过{1}字")]
        public string remarks { get; set; }

        /// <summary>
        ///     创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [Required(ErrorMessage = "请输入{0}")]
        public DateTime createTime { get; set; }
    }
}