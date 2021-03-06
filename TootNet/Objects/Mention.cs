﻿using Newtonsoft.Json;
using TootNet.Internal;

namespace TootNet.Objects
{
    public class Mention : BaseObject
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("acct")]
        public string Acct { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(IdConverter))]
        public long Id { get; set; }
    }
}
