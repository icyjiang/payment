﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPayCodecAcodeDecodeUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayCodecAcodeDecodeUseModel : AlipayObject
    {
        /// <summary>
        /// 具体业务场景代码
        /// </summary>
        [JsonProperty("acode_scene")]
        public string AcodeScene { get; set; }

        /// <summary>
        /// 场景码。用于区分大场景。非必填参数，不传默认是非支付场景
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 扫码设备ID
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 二维码byte数组的base64的形式
        /// </summary>
        [JsonProperty("dynamic_id")]
        public string DynamicId { get; set; }

        /// <summary>
        /// 机构类型,浙里办传“00000008”
        /// </summary>
        [JsonProperty("institution_type")]
        public string InstitutionType { get; set; }

        /// <summary>
        /// 地理位置信息
        /// </summary>
        [JsonProperty("lbs_info")]
        public string LbsInfo { get; set; }

        /// <summary>
        /// 扫码的时间戳(Long型)
        /// </summary>
        [JsonProperty("scan_time")]
        public long ScanTime { get; set; }

        /// <summary>
        /// 外部业务号，用于标识这笔解码请求，对同一个码的重复解码请求，scene_no必须与上一次保持一致，不同请求的scene_no必须不一样
        /// </summary>
        [JsonProperty("scene_no")]
        public string SceneNo { get; set; }
    }
}
