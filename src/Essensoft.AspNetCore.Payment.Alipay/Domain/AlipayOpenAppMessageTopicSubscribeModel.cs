﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppMessageTopicSubscribeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMessageTopicSubscribeModel : AlipayObject
    {
        /// <summary>
        /// 授权令牌
        /// </summary>
        [JsonProperty("auth_token")]
        public string AuthToken { get; set; }

        /// <summary>
        /// 授权类型，例如app_auth表示三方应用授权
        /// </summary>
        [JsonProperty("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 消费该topic消息的通讯协议类型，目前支持HTTP 或者 WebSocket
        /// </summary>
        [JsonProperty("comm_type")]
        public string CommType { get; set; }

        /// <summary>
        /// 消息标签，用于消息子类型过滤。使用前请确认消息topic是否支持
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 消息主题名称
        /// </summary>
        [JsonProperty("topic")]
        public string Topic { get; set; }
    }
}
