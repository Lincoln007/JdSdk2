﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Recommend;

namespace JdSdk.Request.Recommend
{
﻿    public class WareBrowsetobuyListGetRequest : JdRequestBase<WareBrowsetobuyListGetResponse>
    {
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        public String Client
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.ware.browsetobuy.list.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("wareId" ,this.WareId);
            paramters.Add("client" ,this.Client);
        }

    }

}
