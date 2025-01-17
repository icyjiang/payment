﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateLocalfaceCompareSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateLocalfaceCompareSyncModel : AlipayObject
    {
        /// <summary>
        /// 客户端BehaviourLog-> aesCypher 参数
        /// </summary>
        [JsonProperty("aes_cypher")]
        public string AesCypher { get; set; }

        /// <summary>
        /// 参照示例传入
        /// </summary>
        [JsonProperty("alg_ver")]
        public string AlgVer { get; set; }

        /// <summary>
        /// 客户端BehaviourLog->imageBlob参数
        /// </summary>
        [JsonProperty("auth_img")]
        public string AuthImg { get; set; }

        /// <summary>
        /// SCHOOL_PAYMENT: 校园刷脸支付 SCHOOL_ENTRANCE_GUARD:校园门禁
        /// </summary>
        [JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务流水唯一ID,isv自定义，保证唯一性
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 2D或者3D，默认2D
        /// </summary>
        [JsonProperty("face_data_type")]
        public string FaceDataType { get; set; }

        /// <summary>
        /// 参数来源填写特征文件中对应的face_id 人脸本地1:N比对后的用户ID
        /// </summary>
        [JsonProperty("fuid")]
        public string Fuid { get; set; }

        /// <summary>
        /// 必须是由支付宝业务方分配的英文简称(例如:yikeshixx),不能是中文
        /// </summary>
        [JsonProperty("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 国家统一分配的学校社会信用代码(institution_id)
        /// </summary>
        [JsonProperty("organize_id")]
        public string OrganizeId { get; set; }

        /// <summary>
        /// 图片质量分
        /// </summary>
        [JsonProperty("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// 人脸坐标点
        /// </summary>
        [JsonProperty("rect")]
        public string Rect { get; set; }

        /// <summary>
        /// 人脸本地比对分
        /// </summary>
        [JsonProperty("score")]
        public string Score { get; set; }
    }
}
