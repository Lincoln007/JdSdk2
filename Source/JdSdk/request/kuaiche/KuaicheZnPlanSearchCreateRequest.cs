﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Request;
using JdSdk.Response.Kuaiche;

namespace JdSdk.Request.Kuaiche
{
﻿    public class KuaicheZnPlanSearchCreateRequest : JdRequestBase<KuaicheZnPlanSearchCreateResponse>
    {
        public String PlanInfo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.plan.search.create"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("plan_info" ,this.PlanInfo);
        }

    }

}
