﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataBillTransferQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillTransferQueryModel : AlipayObject
    {
        /// <summary>
        /// 充值、转账、提现流水业务时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        [JsonProperty("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小1000-2000，默认2000
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 充值、转账、提现流水业务时间的起始范围
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 转账类型：充值-DEPOSIT，提现-WITHDRAW，转账-TRANSFER。
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
