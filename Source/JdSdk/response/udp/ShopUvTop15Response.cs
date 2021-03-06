﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Udp
{
﻿    [Serializable]
    public class ShopUvTop15Response : JdObject
    {
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        [JsonProperty("sku_id")]
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        [JsonProperty("proname")]
        public String Proname
        {
            get;
            set;
        }

        [JsonProperty("rn")]
        public Nullable<Int32> Rn
        {
            get;
            set;
        }

        [JsonProperty("uv")]
        public Nullable<Int32> Uv
        {
            get;
            set;
        }

    }

}
