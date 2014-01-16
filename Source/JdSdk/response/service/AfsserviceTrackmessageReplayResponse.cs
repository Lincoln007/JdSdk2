﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Service.AfsServiceManagerFacade;

namespace JdSdk.Response.Service
{
﻿    [Serializable]
    public class AfsserviceTrackmessageReplayResponse : JdResponse
    {
        [JsonProperty("trackMessageReplyResult")]
        public TrackMessageReplyResult TrackMessageReplyResult
        {
            get;
            set;
        }

    }

}
