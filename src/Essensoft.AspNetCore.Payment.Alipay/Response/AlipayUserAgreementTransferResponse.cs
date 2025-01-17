﻿using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAgreementTransferResponse.
    /// </summary>
    public class AlipayUserAgreementTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 单次金额限制
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 执行时间
        /// </summary>
        [JsonProperty("execute_time")]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 周期
        /// </summary>
        [JsonProperty("period")]
        public string Period { get; set; }

        /// <summary>
        /// 周期类型
        /// </summary>
        [JsonProperty("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 总金额限制
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 总支付次数
        /// </summary>
        [JsonProperty("total_payments")]
        public string TotalPayments { get; set; }
    }
}
