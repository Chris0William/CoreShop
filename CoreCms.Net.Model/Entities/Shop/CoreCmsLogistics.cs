/***********************************************************************
 *            Project: CoreCms
 *        ProjectName: 核心内容管理系统                                
 *                Web: https://www.corecms.net                      
 *             Author: 大灰灰                                          
 *              Email: jianweie@163.com                                
 *         CreateTime: 2021/1/31 21:45:10
 *        Description: 暂无
 ***********************************************************************/

using System.ComponentModel.DataAnnotations;
using SqlSugar;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    ///     物流公司表
    /// </summary>
    public class CoreCmsLogistics
    {
        /// <summary>
        ///     序列
        /// </summary>
        [Display(Name = "序列")]
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        [Required(ErrorMessage = "请输入{0}")]
        public int id { get; set; }

        /// <summary>
        ///     物流公司名称
        /// </summary>
        [Display(Name = "物流公司名称")]
        [Required(ErrorMessage = "请输入{0}")]
        [StringLength(50, ErrorMessage = "{0}不能超过{1}字")]
        public string logiName { get; set; }

        /// <summary>
        ///     物流公司编码
        /// </summary>
        [Display(Name = "物流公司编码")]
        [Required(ErrorMessage = "请输入{0}")]
        [StringLength(50, ErrorMessage = "{0}不能超过{1}字")]
        public string logiCode { get; set; }

        /// <summary>
        ///     物流logo
        /// </summary>
        [Display(Name = "物流logo")]
        [StringLength(255, ErrorMessage = "{0}不能超过{1}字")]
        public string imgUrl { get; set; }

        /// <summary>
        ///     物流电话
        /// </summary>
        [Display(Name = "物流电话")]
        [StringLength(255, ErrorMessage = "{0}不能超过{1}字")]
        public string phone { get; set; }

        /// <summary>
        ///     物流网址
        /// </summary>
        [Display(Name = "物流网址")]
        [StringLength(255, ErrorMessage = "{0}不能超过{1}字")]
        public string url { get; set; }

        /// <summary>
        ///     排序
        /// </summary>
        [Display(Name = "排序")]
        [Required(ErrorMessage = "请输入{0}")]
        public int sort { get; set; }

        /// <summary>
        ///     是否删除
        /// </summary>
        [Display(Name = "是否删除")]
        [Required(ErrorMessage = "请输入{0}")]
        public bool isDelete { get; set; }
    }
}