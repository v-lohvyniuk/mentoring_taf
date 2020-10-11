using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace mentoring_taf.taf.core.api.client
{
    public class ApiClient
    {
        private static readonly string DEFAULT_BASE_URL = "http://dummy.restapiexample.com/";

        private static ApiClient apiClient;
        
        private string baseUrl;
        private RestClient restClient;
        private RequestData requestData;

        private ApiClient(string baseUrl, RestClient client)
        {
            this.baseUrl = baseUrl;
            this.restClient = client;
            this.restClient.BaseUrl = new Uri(this.baseUrl);
        }

        public static ApiClient GetInstance()
        {
            if(null == apiClient)
            {
                RestClient client = new RestClient();
                apiClient = new ApiClient(DEFAULT_BASE_URL, client);
            }
            return apiClient;
        }

        public ApiClient WithRequestData(RequestData requestData)
        {
            apiClient.requestData = requestData;
            return this;
        }

        public void DoGet()
        {
            RestRequest request = new RestRequest(this.requestData.Url, Method.GET);
            foreach(var item in this.requestData.QueryParams)
            {
                request.AddQueryParameter(item.Key, item.Value);
            }
            this.restClient.Execute(request);
        }
    }
}
