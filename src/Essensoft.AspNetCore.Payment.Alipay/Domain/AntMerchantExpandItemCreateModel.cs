﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandItemCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemCreateModel : AlipayObject
    {
        /// <summary>
        /// 详情地址
        /// </summary>
        [JsonProperty("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 商品扩展信息：可以解析成 Map<String, String> 的 json string
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [JsonProperty("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 前台类目id：target_type + target_id 和 front_category_id 二选一
        /// </summary>
        [JsonProperty("front_category_id")]
        public string FrontCategoryId { get; set; }

        /// <summary>
        /// 商品标签列表
        /// </summary>
        [JsonProperty("label_list")]
        public List<ItemLabelCreateInfo> LabelList { get; set; }

        /// <summary>
        /// 主图地址
        /// </summary>
        [JsonProperty("main_pic")]
        public string MainPic { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 场景：GAS_CHARGE（加油）
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商品sku列表，至少有一个
        /// </summary>
        [JsonProperty("sku_list")]
        public List<ItemSkuCreateInfo> SkuList { get; set; }

        /// <summary>
        /// 商户归属主体id
        /// </summary>
        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型：target_type + target_id 和 front_category_id 二选一    商品归属主体类型:  5: 店铺  4: 主站MID  3: 参与者  2: 角色  1: 联系人
        /// </summary>
        [JsonProperty("target_type")]
        public string TargetType { get; set; }
    }
}
