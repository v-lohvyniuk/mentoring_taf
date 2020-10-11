using AngleSharp.Html.Dom;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace mentoring_taf.taf.core.api.client
{
    public class RequestData
    {

        public String Url { get; set; }

        public IDictionary<string, string> QueryParams { get; set; }


        public RequestData()
        {
            QueryParams = new Dictionary<string, string>();
        }
        public RequestData WithQueryParam(string key, string value)
        {
            this.QueryParams.Add(key, value);
            return this;
        }

        public RequestData WithUrl(string url)
        {
            this.Url = url;
            return this;
        }
    }
}
