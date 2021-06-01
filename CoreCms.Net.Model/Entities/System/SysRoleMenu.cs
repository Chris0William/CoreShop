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
    ///     角色菜单关联表
    /// </summary>
    public partial class SysRoleMenu
    {
        /// <summary>
        ///     主键
        /// </summary>
        [Display(Name = "主键")]
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        [Required(ErrorMessage = "请输入{0}")]
        public int id { get; set; }

        /// <summary>
        ///     角色id
        /// </summary>
        [Display(Name = "角色id")]
        [Required(ErrorMessage = "请输入{0}")]
        public int roleId { get; set; }

        /// <summary>
        ///     菜单id
        /// </summary>
        [Display(Name = "菜单id")]
        [Required(ErrorMessage = "请输入{0}")]
        public int menuId { get; set; }

        /// <summary>
        ///     创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [Required(ErrorMessage = "请输入{0}")]
        public DateTime createTime { get; set; }

        /// <summary>
        ///     修改时间
        /// </summary>
        [Display(Name = "修改时间")]
        public DateTime? updateTime { get; set; }
    }
}