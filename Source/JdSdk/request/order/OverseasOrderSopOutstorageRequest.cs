﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Order;

namespace JdSdk.Request.Order
{
﻿    public class OverseasOrderSopOutstorageRequest : JdRequestBase<OverseasOrderSopOutstorageResponse>
    {
        public String OrderId
        {
            get;
            set;
        }

        public String TradeNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.overseas.order.sop.outstorage"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("trade_no" ,this.TradeNo);
        }

    }

}
