﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class QueryOrderForJosResultDto : JdObject
    {
        [JsonProperty("customOrderId")]
        public Nullable<Int64> CustomOrderId
        {
            get;
            set;
        }

        [JsonProperty("pay")]
        public Nullable<Decimal> Pay
        {
            get;
            set;
        }

        [JsonProperty("operatorState")]
        public Nullable<Int32> OperatorState
        {
            get;
            set;
        }

        [JsonProperty("consigneeName")]
        public String ConsigneeName
        {
            get;
            set;
        }

        [JsonProperty("postcode")]
        public String Postcode
        {
            get;
            set;
        }

        [JsonProperty("expectedDeliveryTime")]
        public Nullable<DateTime> ExpectedDeliveryTime
        {
            get;
            set;
        }

        [JsonProperty("telephone")]
        public String Telephone
        {
            get;
            set;
        }

        [JsonProperty("phone")]
        public String Phone
        {
            get;
            set;
        }

        [JsonProperty("email")]
        public String Email
        {
            get;
            set;
        }

        [JsonProperty("address")]
        public String Address
        {
            get;
            set;
        }

        [JsonProperty("orderTime")]
        public Nullable<DateTime> OrderTime
        {
            get;
            set;
        }

        [JsonProperty("orderRemark")]
        public String OrderRemark
        {
            get;
            set;
        }

        [JsonProperty("orderCreateDate")]
        public Nullable<DateTime> OrderCreateDate
        {
            get;
            set;
        }

        [JsonProperty("isNotice")]
        public Nullable<Int32> IsNotice
        {
            get;
            set;
        }

        [JsonProperty("sendPay")]
        public String SendPay
        {
            get;
            set;
        }

        [JsonProperty("paymentCategory")]
        public String PaymentCategory
        {
            get;
            set;
        }

        [JsonProperty("paymentCategoryDispName")]
        public String PaymentCategoryDispName
        {
            get;
            set;
        }

        [JsonProperty("createDate")]
        public Nullable<DateTime> CreateDate
        {
            get;
            set;
        }

        [JsonProperty("pin")]
        public String Pin
        {
            get;
            set;
        }

        [JsonProperty("refundSourceFlag")]
        public Nullable<Int32> RefundSourceFlag
        {
            get;
            set;
        }

        [JsonProperty("provinceName")]
        public String ProvinceName
        {
            get;
            set;
        }

        [JsonProperty("cityName")]
        public String CityName
        {
            get;
            set;
        }

        [JsonProperty("countyName")]
        public String CountyName
        {
            get;
            set;
        }

        [JsonProperty("townName")]
        public String TownName
        {
            get;
            set;
        }

        [JsonProperty("orderDetailList")]
        public List<OrderDetailForJosDto> OrderDetailList
        {
            get;
            set;
        }

    }

}
