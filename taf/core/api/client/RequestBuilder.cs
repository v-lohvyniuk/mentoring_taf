using AngleSharp;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.core.api.client
{
    public class RequestBuilder
    {

        private IRestRequest request;

        public RequestBuilder()
        {
            request = new RestRequest();
        }

        public RequestBuilder Path(String path)
        {
            request.Resource = path;
            return this;
        }

        public RequestBuilder QueryParams(Dictionary<String, String> queryParams)
        {
            foreach(var queryParam in queryParams)
            {
                this.QueryParam(queryParam.Key, queryParam.Value);
            }
            return this;
        }
        
        public RequestBuilder QueryParam(String key, String value)
        {
            request.AddQueryParameter(key, value);
            return this;
        }

        public RequestBuilder Body<T>(T body)
        {
            request.AddJsonBody(body);
            return this;
        }

        public IRestRequest Build()
        {
            return this.request;
        }
    }
}
