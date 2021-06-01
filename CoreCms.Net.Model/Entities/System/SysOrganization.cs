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
    ///     组织机构表
    /// </summary>
    public class SysOrganization
    {
        /// <summary>
        ///     机构id
        /// </summary>
        [Display(Name = "机构id")]
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        [Required(ErrorMessage = "请输入{0}")]
        public int id { get; set; }

        /// <summary>
        ///     上级id,0是顶级
        /// </summary>
        [Display(Name = "上级id,0是顶级")]
        [Required(ErrorMessage = "请输入{0}")]
        public int parentId { get; set; }

        /// <summary>
        ///     机构名称
        /// </summary>
        [Display(Name = "机构名称")]
        [StringLength(50, ErrorMessage = "{0}不能超过{1}字")]
        public string organizationName { get; set; }

        /// <summary>
        ///     机构名称
        /// </summary>
        [Display(Name = "机构名称")]
        [StringLength(50, ErrorMessage = "{0}不能超过{1}字")]
        public string organizationFullName { get; set; }

        /// <summary>
        ///     机构类型
        /// </summary>
        [Display(Name = "机构类型")]
        [Required(ErrorMessage = "请输入{0}")]
        public int organizationType { get; set; }

        /// <summary>
        ///     负责人id
        /// </summary>
        [Display(Name = "负责人id")]
        public int? leaderId { get; set; }

        /// <summary>
        ///     排序号
        /// </summary>
        [Display(Name = "排序号")]
        [Required(ErrorMessage = "请输入{0}")]
        public int sortNumber { get; set; }

        /// <summary>
        ///     备注
        /// </summary>
        [Display(Name = "备注")]
        [StringLength(500, ErrorMessage = "{0}不能超过{1}字")]
        public string comments { get; set; }

        /// <summary>
        ///     是否删除,0否,1是
        /// </summary>
        [Display(Name = "是否删除,0否,1是")]
        [Required(ErrorMessage = "请输入{0}")]
        public bool deleted { get; set; }

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