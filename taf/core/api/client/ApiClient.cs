using mentoring_taf.taf.core.logging;
using RestSharp;
using System;

namespace mentoring_taf.taf.core.api.client
{
    public class ApiClient
    {
        private static readonly string DEFAULT_BASE_URL = "http://dummy.restapiexample.com/api/v1";

        private static ApiClient apiClient;
        
        private string baseUrl;
        private RestClient restClient;

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

        public RequestBuilder Request()
        {
            return new RequestBuilder();
        }

        public IRestResponse GET(IRestRequest request)
        {
            return DoExecuteRequest(Method.GET, request);
        }
        
        public IRestResponse POST(IRestRequest request)
        {
            return DoExecuteRequest(Method.POST, request);
        }
        
        public IRestResponse PUT(IRestRequest request)
        {
            return DoExecuteRequest(Method.PUT, request);
        }
        
        public IRestResponse DELETE(IRestRequest request)
        {
            return DoExecuteRequest(Method.DELETE, request);
        }
        
        private IRestResponse DoExecuteRequest(Method method, IRestRequest request)
        {
            request.Method = method;

            RequestResponseLogger.LogRequest(this.restClient, request);
            
            IRestResponse response = this.restClient.Execute(request);
            
            RequestResponseLogger.LogResponse(response);
            return response;
        }
    }
}
