﻿/***********************************************************************
 *            Project: CoreCms.Net                                     *
 *                Web: https://CoreCms.Net                             *
 *        ProjectName: 核心内容管理系统                                *
 *             Author: 大灰灰                                          *
 *              Email: JianWeie@163.com                                *
 *         CreateTime: 2020-08-25 1:25:29
 *        Description: 暂无
 ***********************************************************************/


using System;
using CoreCms.Net.IServices;
using CoreCms.Net.Loging;
using CoreCms.Net.Model.Entities;
using Newtonsoft.Json;
using NLog;

namespace CoreCms.Net.Task
{
    /// <summary>
    ///     未付款订单超时后取消订单操作任务
    /// </summary>
    public class AutoCancelOrderJob
    {
        private readonly ICoreCmsOrderServices _orderServices;

        public AutoCancelOrderJob(ICoreCmsOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        public async System.Threading.Tasks.Task Execute()
        {
            await _orderServices.AutoCancelOrder();
        }
    }
}