﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandShopModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandShopModifyModel : AlipayObject
    {
        /// <summary>
        /// 门店结算卡信息。本业务当前只允许传入一张结算卡
        /// </summary>
        [JsonProperty("biz_cards")]
        public List<SettleCardInfo> BizCards { get; set; }

        /// <summary>
        /// 品牌id。若无需更新本信息项，可以不填写
        /// </summary>
        [JsonProperty("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 经营地址。若填写本对象，其中省、市、区、地址必填，其余选填。无需更新本信息项时请整体留空，如有填写将整体覆盖本信息项
        /// </summary>
        [JsonProperty("business_address")]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 店铺经营时间。若无需更新本信息项，可以不填写
        /// </summary>
        [JsonProperty("business_time")]
        public List<ShopBusinessTime> BusinessTime { get; set; }

        /// <summary>
        /// 营业执照图片url。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。当店铺类目为特殊行业时要求本信息项。若无需更新本信息项，可以不填写
        /// </summary>
        [JsonProperty("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 营业执照名称，填写值为营业执照或统一社会信用代码证上的名称。当店铺类目是特殊类目是要求本信息项。若无需更新本信息项，可以不填写
        /// </summary>
        [JsonProperty("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码。请填写店铺营业执照号。当店铺类目是特殊类目是要求必填。若无需更新本信息项，可以不填写，以原有值为准
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，取值范围：201：营业执照；2011:多证合一(统一社会信用代码)。当店铺类目是特殊类目是要求本信息项。若无需更新本信息项，可以不填写
        /// </summary>
        [JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 联系人信息。如果填写，其中名称必填，手机、固话、email三选一必填。填写则会将本信息项整体更新，覆盖原有的所有联系人
        /// </summary>
        [JsonProperty("contact_infos")]
        public ContactInfo ContactInfos { get; set; }

        /// <summary>
        /// 店铺联系手机。若无需更新本信息项，可以不填写，以原有值为准
        /// </summary>
        [JsonProperty("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 店铺的联系固话。若无需更新本信息项，可以不填写，以原有值为准
        /// </summary>
        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 扩展信息列表。key值需要向对应行业的bd进行申请。传入本项时，按key进行更新或补充
        /// </summary>
        [JsonProperty("ext_infos")]
        public List<ShopExtInfo> ExtInfos { get; set; }

        /// <summary>
        /// 商户角色id，表示将要修改的店属于哪个商户角色，和store_id一起定位待修改的门店。对于直连场景，填写商户pid；对于间连场景（线上、线下、直付通），填写商户smid。本接口中，如果没传shop_id，则本字段与store_id均必填。本信息项不可修改
        /// </summary>
        [JsonProperty("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 法人身份证号。如果要更新，必须和legal_name成对传入
        /// </summary>
        [JsonProperty("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人名称。如果要更新，必须和legal_name成对传入
        /// </summary>
        [JsonProperty("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 营业执照授权函。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。当店铺类目是特殊行业时要求本信息项。若无需更新本信息项，可以不填写
        /// </summary>
        [JsonProperty("license_auth_letter_image")]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 备注。若无需更新本信息项，可以不填写
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 门头照，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。当店铺类目是特殊类目要求本信息项。若无需更新本信息项，可以不填写。若填写则会整体覆盖原有的门头照列表
        /// </summary>
        [JsonProperty("out_door_images")]
        public List<string> OutDoorImages { get; set; }

        /// <summary>
        /// 行业特殊资质。当店铺类目是特殊类目是要求本信息项。若无需更新本信息项，可以不填写。填写会按类型进行更新或补充
        /// </summary>
        [JsonProperty("qualifications")]
        public List<IndustryQualificationInfo> Qualifications { get; set; }

        /// <summary>
        /// 场景。若无需更新本信息项，可以不填写
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 结算支付宝账号的登录号。若无需更新本信息项，可以不填写
        /// </summary>
        [JsonProperty("settle_alipay_logon_id")]
        public string SettleAlipayLogonId { get; set; }

        /// <summary>
        /// 店铺类目，取值参见文件https://mif-pub.alipayobjects.com/ShopCategory.xlsx 中的三级门店类目。若无需更新本信息项，可以不填写
        /// </summary>
        [JsonProperty("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 蚂蚁店铺id，用于查出待修改的门店。填写本参数的话，store_id和ip_role_id可以不填。本信息项不可修改
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称。直连开店要保证全局店铺名称+地址唯一，间连开店要保证服务商pid下店铺名称+地址唯一。若无需更新本信息项，可以不填写
        /// </summary>
        [JsonProperty("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店编号，表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号。用于查出待修改的门店。本接口中，如果没传shop_id，则本字段与ip_role_id均必填；传入shop_id情况下，以shop_id为准查询门店，并修改本信息项
        /// </summary>
        [JsonProperty("store_id")]
        public string StoreId { get; set; }
    }
}
